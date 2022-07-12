using CanWeFixItApplication.Dtos;
using CanWeFixItDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CanWeFixItApplication.Contracts.Persistence
{
    public interface IInstrumentRepository : IGenericRepository<Instrument>
    {
        Task<IEnumerable<InstrumentDto>> GetAllActiveAsync();
    }
}
