using MyProject.Models;
using MyProject.Data;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Services;

public class CourseService
{
    private readonly ApiContext _context;

    public CourseService(ApiContext context)
    {
        _context = context;
    }

    // CREATE: Add a new course
    public async Task AddCourse(Course course)
    {
        _context.Courses.Add(course);
        await _context.SaveChangesAsync();
    }

    // READ: Get all courses
    public async Task<List<Course>> GetAllCourses()
    {
        return await _context.Courses.Include(c => c.Students).ToListAsync();
    }

    // DELETE: Remove a course
    public async Task DeleteCourse(int id)
    {
        var course = await _context.Courses.FindAsync(id);
        if (course != null)
        {
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }
    }
}