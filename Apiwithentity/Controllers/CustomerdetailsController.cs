using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Apiwithentity.Model;

namespace Apiwithentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerdetailsController : ControllerBase
    {
        private readonly ICustomerdetailsRepository _customerdetailsRepository;

        public CustomerdetailsController(ICustomerdetailsRepository customerdetailsRepository)
        {
            _customerdetailsRepository = customerdetailsRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var data = _customerdetailsRepository.GetAllCustomerdetails();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _customerdetailsRepository.GetAllCustomerdetailsById(id);
            if (data == null)
                return NotFound("no record found using id:" + id);
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(Customerdetails customerdetails)
        {
            var data = _customerdetailsRepository.AddCustomerdetials(customerdetails);
            if (data == null)
                return BadRequest("try again if possible..");
            return Created(HttpContext.Request.Scheme +
               "://" + HttpContext.Request.Host + "/" + HttpContext.Request.Path + "/" +
               customerdetails.Id, data);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _customerdetailsRepository.DeleteCustomerdetails(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Customerdetails customerdetails)
        {
            var data = _customerdetailsRepository.UpdateCustomerdetails(customerdetails, id);
            return Ok(data);
        }

    }
}
