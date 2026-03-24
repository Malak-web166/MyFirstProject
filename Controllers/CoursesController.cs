using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using MyProject.Services;

namespace MyProject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
    private readonly CourseService _courseService;

    public CoursesController(CourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCourse(Course course)
    {
        // OBJECTIVE 5 & 6: Validation and Error Response
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); // Returns a 400 Error if rules are broken
        }

        await _courseService.AddCourse(course);
        return Ok(course); // Returns a 200 Success if everything is perfect
    }

    [HttpGet]
    public async Task<IActionResult> GetCourses()
    {
        var courses = await _courseService.GetAllCourses();
        return Ok(courses);
    }
}