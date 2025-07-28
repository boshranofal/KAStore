using KAStore.BLL.Serviece.Interfaces;
using KAStore.DAL.DTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KAStore.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandServices _brandServiece;

        public BrandsController(IBrandServices brandServiece)
        {
            brandServiece = _brandServiece;
        }

        [HttpGet("")]
        public IActionResult GetAll() => Ok(_brandServiece.GetAll());


        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var brand = _brandServiece.GetById(id);
            if (brand == null)
            {
                return NotFound();
            }
            return Ok(brand);
        }
        [HttpPost]

        public IActionResult Create([FromBody] BrandRequest request)
        {
            var id = _brandServiece.Create(request);
            return CreatedAtAction(nameof(GetById), new { id }, new { message = "Ok " });
        }
        [HttpPatch("{Id}")]
        public IActionResult Update([FromRoute] int Id, [FromBody] BrandRequest request)
        {
            var update = _brandServiece.Update(Id, request);
            return update > 0 ? Ok() : NotFound();
        }
        [HttpPatch("ToggleStatus/{id}")]
        public IActionResult ToggleStatus([FromRoute] int id)
        {
            var update = _brandServiece.ToggleStatus(id);
            return update ? Ok(new { message = "status toggled" }) : NotFound(new { message = "brand not found" });
        }
        [HttpDelete("Id")]
        public IActionResult Delete(int id)
        {
            var deleted = _brandServiece.Delete(id);
            return deleted > 0 ? Ok() : NotFound();
        }

    }
}
