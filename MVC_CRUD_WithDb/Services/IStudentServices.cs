using Microsoft.EntityFrameworkCore.Update.Internal;
using MVC_CRUD_WithDb.Models;

namespace MVC_CRUD_WithDb.Services;

public interface IStudentServices
{
    List<Student> Students { get; }

    public List<Student> GetAllStudents(); // Retrieve all students

    public Student GetStudent(int id); // Get one student

    public string DeleteStudent(int id); // Delte a student

    public Student AddStudent(Student student); // Add a single student

    public Student UpdateStudent(Student student); // Udpate a single student

    public IEnumerable<Student> GetTopStudents(double grade); // Get top students based off of grade
}
