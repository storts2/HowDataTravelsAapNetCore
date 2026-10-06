using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD_WithDb.Models;

public class Student
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public double? Grade { get; set; }

}
