using System;
using System.ComponentModel.DataAnnotations;
public class TodoItem
{
    [Required]
    public string Title { get; set; }
    public bool IsDone { get; set; }
    [StringLength(50, ErrorMessage = "Identifier too long (50 character limit).")]
    public string Content { get; set; }

    [Required]
    [DateInFuture]
    public DateTime? DueDate { get; set; }
}
 