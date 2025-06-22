using kolokwiumPoprawkowe.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace kolokwiumPoprawkowe.Controllers
{
    [Route("galleries")]
    [ApiController]
    public class GalleryController : ControllerBase
    {

        private readonly IDbService _dbService;

     
        public GalleryController(IDbService dbService)
        {
            _dbService = dbService;
        }
        [HttpGet("{id}/exhibitions")]
        public async Task<IActionResult> GetPurchaseInfo(int id)
        {
            var purchase = await _dbService.GalleryInfoAsync(id);
            return Ok(purchase);
        }

    }
}
