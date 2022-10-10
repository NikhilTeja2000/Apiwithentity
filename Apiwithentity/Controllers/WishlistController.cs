using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Apiwithentity.Model;

namespace Apiwithentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishlistController : ControllerBase
    {
        private IUserWishlistRepository userwishlistRepository;
        public WishlistController(IUserWishlistRepository userwishlistRepository)
        {
            this.userwishlistRepository = userwishlistRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = userwishlistRepository.GetAllWishlist();
            return Ok(data);
        }
       
        [HttpPost]
        public IActionResult Post([FromBody] Wishlist wishlist)
        {
            var data = userwishlistRepository.AddWishlist(wishlist);
            return Ok(wishlist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = userwishlistRepository.GetWishlistById(id);
            if (data == null)
                return NotFound("nothing is there Try again");
            return Ok(data);
        }

    }
}
