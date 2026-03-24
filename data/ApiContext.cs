using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject.Data;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
}