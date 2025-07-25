using KAStore.BLL.Serviece;
using KAStore.DAL.DTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KAStore.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryServiece categoryServiece;

        public CategoriesController( ICategoryServiece categoryServiece)
        {
            this.categoryServiece = categoryServiece;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(categoryServiece.GetAllCategories()); 
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            var category=categoryServiece.GetCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpPost]

        public IActionResult Create([FromBody]CategoryRequest request)
        {
            var id =categoryServiece.CreateCategory(request);
            return CreatedAtAction(nameof(GetById),new { id });
        }
        [HttpPatch("{Id}")]
        public IActionResult Update([FromRoute]int Id, [FromBody] CategoryRequest request)
        {
            var update=categoryServiece.Update(Id,request);
            return update > 0 ? Ok() : NotFound();
        }
        [HttpPatch("ToggleStatus/{id}")]
        public IActionResult ToggleStatus([FromRoute]int id)
        {
            var update=categoryServiece.ToggleStatus(id);
            return update ? Ok(new { message = "status toggled" }) : NotFound(new { message = "category not found" });
        }
        [HttpDelete("Id")]
        public IActionResult Delete(int id)
        {
            var deleted=categoryServiece.DeleteCategory(id);
            return deleted > 0 ? Ok() : NotFound();
        }

    }
}
