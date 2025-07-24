using System.ComponentModel.DataAnnotations;

namespace NetMVC.Models;

public class Student
{
    [Key]
    public string? StudentId { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
    public bool ShowRequestId => !string.IsNullOrEmpty(StudentId);
}
