using CanWeFixItApplication.Contracts;
using CanWeFixItApplication.Contracts.Persistence;
using CanWeFixItApplication.Dtos;
using CanWeFixItDomain;
using CanWeFixItPersistence.Common;
using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CanWeFixItPersistence.Repository
{
    public class InstrumentRepository : GenericRepository<Instrument>, IInstrumentRepository
    {
        private SqliteConnection _connection;
        public InstrumentRepository(IDatabaseService databaseService) : base(databaseService)
        {
            _connection = databaseService.GetConnection();
        }

        public async Task<IEnumerable<InstrumentDto>> GetAllActiveAsync()
        {
            var instruments = await _connection.QueryAsync<Instrument>(SqlStatement.AllActiveInstrument);

            //Map Model to Dto
            var instrumentDtos = new List<InstrumentDto>();
            foreach(var instrument in instruments)
            {
                instrumentDtos.Add(new InstrumentDto { Id = instrument.Id, Sedol = instrument.Sedol, Name = instrument.Sedol, Active = instrument.Active });
            }

            return instrumentDtos;
        }

    }
}
