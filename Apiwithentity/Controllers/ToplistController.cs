using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Apiwithentity.Model;

namespace Apiwithentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToplistController : ControllerBase
    {
        private IToplistRepository toplistRepository;
        public ToplistController(IToplistRepository toplistRepository)
        {
            this.toplistRepository = toplistRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = toplistRepository.GetAllToplist();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = toplistRepository.GetToplistById(id);
            if (data == null)
                return NotFound("nothing is there Try again");
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Toplist toplist)
        {
            var data = toplistRepository.AddToplist(toplist);
            return Ok(toplist);
        }
    }
}
