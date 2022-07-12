using CanWeFixItApplication.Contracts;
using CanWeFixItApplication.Contracts.Persistence;
using CanWeFixItApplication.Dtos;
using CanWeFixItDomain;
using CanWeFixItPersistence.Common;
using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanWeFixItPersistence.Repository
{
    public class MarketDataRepository : GenericRepository<MarketData>, IMarketDataRepository
    {
        private SqliteConnection _connection;
        public MarketDataRepository(IDatabaseService databaseService) : base(databaseService)
        {
            _connection = databaseService.GetConnection();
        }

        public async Task<IEnumerable<MarketDataDto>> GetAllActiveAsync()
        {
            var marketDatas = await _connection.QueryAsync<MarketData>(SqlStatement.AllActiveMarketData);

            var instrumentDatas = (await _connection.QueryAsync<Instrument>(SqlStatement.AllInstrument))
                                    .Select(x => new KeyValuePair<string, int>(x.Sedol, x.Id))
                                    .ToDictionary(x => x.Key, x => x.Value);

            //Map Model to Dto
            var marketDataDtos = new List<MarketDataDto>();
            foreach (var marketData in marketDatas)
            {
                try
                {
                    var instrumentId = instrumentDatas[marketData.Sedol.ToString()];
                    marketDataDtos.Add(new MarketDataDto { Id = marketData.Id, InstrumentId = instrumentId, DataValue = marketData.DataValue, Active = marketData.Active });
                }
                catch
                {
                    //KeyValue Not found error occurs, loop for next
                }
            }

            return marketDataDtos;
        }

        public async Task<IEnumerable<MartketValuationDto>> GetDataValueTotalAsync()
        {
            var martketValuationDto = new List<MartketValuationDto>();
            var total = (await _connection.QueryAsync<MarketValuation>(SqlStatement.MarketDataValueTotal)).FirstOrDefault().Total;

            //Map Model to Dto
            martketValuationDto.Add(new MartketValuationDto { Name = Constants.ValuationFieldName, Total = total});

            return martketValuationDto;
        }
    }
}
