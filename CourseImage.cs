using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("course_image")]
public class CourseImage
{
    [Key]
    public int CourseImageId { get; set; }
    public byte[] Image { get; set; }
    public string Caption { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; }
}
