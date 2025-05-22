using System.ComponentModel.DataAnnotations;

public class Note
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string Content { get; set; }
}
