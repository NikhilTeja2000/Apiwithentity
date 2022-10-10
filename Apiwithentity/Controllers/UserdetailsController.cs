using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Apiwithentity.Model;

namespace Apiwithentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserdetailsController : ControllerBase
    {
        private readonly IUserdetailsRepository _userdetailsRepository;

        public UserdetailsController(IUserdetailsRepository userdetailsRepository)
        {
            _userdetailsRepository = userdetailsRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var data = _userdetailsRepository.GetAllUserdetails();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _userdetailsRepository.GetAllUserdetailsById(id);
            if (data == null)
                return NotFound("no record found using id:" + id);
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(Userdetails userdetails)
        {
            var data = _userdetailsRepository.AddUserdetials(userdetails);
            if (data == null)
                return BadRequest("try again if possible..");
            return Created(HttpContext.Request.Scheme +
               "://" + HttpContext.Request.Host + "/" + HttpContext.Request.Path + "/" +
               userdetails.Id, data);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userdetailsRepository.DeleteUserdetails(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Userdetails userdetails)
        {
            var data = _userdetailsRepository.UpdateUserdetails(userdetails, id);
            return Ok(data);
        }

    }
}
