using System.Collections.Generic;
using System.Threading.Tasks;
using CanWeFixItApplication.Contracts.Persistence;
using CanWeFixItApplication.Dtos;
using CanWeFixItDomain;
using Microsoft.AspNetCore.Mvc;

namespace CanWeFixItApi.Controllers
{
    [ApiController]
    [Route("v1/instruments")]
    public class InstrumentController : ControllerBase
    {
        private IInstrumentRepository _instrumentRepository;
        public InstrumentController(IInstrumentRepository instrumentRepository)
        {
            _instrumentRepository = instrumentRepository;
        }
        
        // GET
        public async Task<ActionResult<IEnumerable<InstrumentDto>>> Get()
        {
            return Ok(await _instrumentRepository.GetAllActiveAsync());
        }
    }
}