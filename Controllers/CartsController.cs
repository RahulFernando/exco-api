using System.Threading.Tasks;
using exco_api.IService;
using exco_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace exco_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody] Cart cart)
        {
            var result = await _cartService.AddToCart(cart);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCart(int id)
        {
            var result = await _cartService.GetCart(id);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStatus([FromBody] Item item)
        {
            var result = await _cartService.UpdateItem(item);

            return Ok(result);
        }
    }
}