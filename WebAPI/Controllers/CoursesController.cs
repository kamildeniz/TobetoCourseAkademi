using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _courseService.GetAll();
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _courseService.GetById(id);
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add(CourseDTO courseDTO)
        {
            var result = _courseService.Add(courseDTO);
            return Ok(result);
        }
        [HttpPut("update")]
        public IActionResult Update(CourseDTO courseDTO)
        {
            var result = _courseService.Update(courseDTO);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _courseService.Delete(id);
            return Ok(result);
        }
    }
}
