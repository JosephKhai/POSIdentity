using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosShopController : ControllerBase
    {
        private readonly IPosShopService _posShopService;

        public PosShopController(IPosShopService posShopService)
        {
            _posShopService = posShopService;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var posShop = await _posShopService.GetShopListAsync();
            return Ok(posShop);
        }
    }
}
