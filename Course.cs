using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("course")]
public class Course
{
    [Key]
    public int CourseId { get; set; }
    public string Name { get; set; }

    public CourseImage CourseImage { get; set; }

    public List<Student> StudentsEnrolled { get; set; }
}
