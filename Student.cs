using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("student")]
public class Student
{
    [Key]
    public int StudentId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Surname { get; set; }

    [Column("student_email")]
    public string Email { get; set; }

    public List<Review> Reviews { get; set; }

    public List<Course> FrequentedCourses { get; set; }

    
}
