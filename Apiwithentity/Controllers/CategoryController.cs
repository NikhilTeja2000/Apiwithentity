using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Apiwithentity.Model;
namespace Apiwithentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var data = _categoryRepository.GetAllCategory();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _categoryRepository.GetAllCategoryById(id);
            if (data == null)
                return NotFound("no record found using id:" + id);
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(Category category)
        {
            var data = _categoryRepository.AddCategory(category);
            if (data == null)
                return BadRequest("try again if possible..");
            return Created(HttpContext.Request.Scheme +
               "://" + HttpContext.Request.Host + "/" + HttpContext.Request.Path + "/" +
               category.Id, data);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Category category)
        {
            var data = _categoryRepository.UpdateCategory(category, id);
            return Ok(data);
        }

    }
}
