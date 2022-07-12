using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("review")]
public class Review
{
    [Key]
    public int ReviewId { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }
}
