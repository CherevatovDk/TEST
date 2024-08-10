namespace Pschool.Core.DTOs;

public class StudentDto
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int ParentId { get; set; }
}