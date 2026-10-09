using MVC_CRUD_WithDb.Context;
using MVC_CRUD_WithDb.Models;

namespace MVC_CRUD_WithDb.Services;

public class StudentServices : IStudentServices
{
    private readonly SchoolDbContext _context;

    public StudentServices(SchoolDbContext context)
    {
        _context = context;
    }

    public List<Student> Students { get; }

    public List<Student> GetAllStudents()
    {
        return _context.Students.ToList();
    }

    public Student GetStudent(int id)
    {
        return _context.Students.FirstOrDefault(s => s.Id == id);
    }

    public string DeleteStudent(int id)
    {
        _context.Students.Remove(GetStudent(id));
        _context.SaveChanges();
        return "Student Deleted";
    }

    public Student AddStudent(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();
        return student;
    }

    public Student UpdateStudent(Student student)
    {
        _context.Students.Update(student);
        _context.SaveChanges();
        return student;
    }

    public IEnumerable<Student> GetTopStudents(double grade)
    {
        return _context.Students.Where(s => s.Grade == grade);
    }
}
