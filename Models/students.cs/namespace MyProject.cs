using System.ComponentModel.DataAnnotations;

namespace MyProject.Models;

public class Course 
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Course Name is required!")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters.")]
    public string Name { get; set; } = "";

    public List<Student> Students { get; set; } = new(); 
}