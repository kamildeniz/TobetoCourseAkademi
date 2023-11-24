using Business.Abstract;
using Entities.Concrete.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add(CategoryDTO categoryDTO)
        {
            var result = _categoryService.Add(categoryDTO);
            return Ok(result);
        }
        [HttpPut("update")]
        public IActionResult Update(CategoryDTO categoryDTO)
        {
            var result = _categoryService.Update(categoryDTO);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _categoryService.Delete(id);
            return Ok(result);
        }
    }
}
