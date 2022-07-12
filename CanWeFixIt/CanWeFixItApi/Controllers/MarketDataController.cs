using System.Collections.Generic;
using System.Threading.Tasks;
using CanWeFixItApplication.Contracts.Persistence;
using CanWeFixItApplication.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CanWeFixItApi.Controllers
{
    [ApiController]
    //[Route("v2")]
    public class MarketDataController : ControllerBase
    {
        private IMarketDataRepository _marketDataRepository;
        public MarketDataController(IMarketDataRepository marketDataRepository)
        {
            _marketDataRepository = marketDataRepository;
        }

        // GET
        [HttpGet("/v1/marketdata")]
        public async Task<ActionResult<IEnumerable<MarketDataDto>>> Get()
        {
            return Ok(await _marketDataRepository.GetAllActiveAsync());
        }

        // GET
        [HttpGet("/v1/valuations")]
        public async Task<ActionResult<IEnumerable<MartketValuationDto>>> GetMarketValuation()
        {
            return Ok(await _marketDataRepository.GetDataValueTotalAsync());
        }
    }
}