using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Apiwithentity.Model;

namespace Apiwithentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private ICartRepository cartRepository;
        public CartController(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = cartRepository.GetAllCart();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cart cart)
        {
            var data = cartRepository.AddCart(cart);
            return Ok(cart);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = cartRepository.GetCartById(id);
            if (data == null)
                return NotFound("nothing is there Try again");
            return Ok(data);
        }

    }
}

