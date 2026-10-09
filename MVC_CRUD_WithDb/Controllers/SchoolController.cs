using Microsoft.AspNetCore.Mvc;
using MVC_CRUD_WithDb.Models;
using MVC_CRUD_WithDb.Services;

namespace MVC_CRUD_WithDb.Controllers;

public class SchoolController : Controller
{
    private readonly IStudentServices studentServices;

    public SchoolController(IStudentServices studentServices)
    {
        this.studentServices = studentServices;
    }

    public IActionResult ShowStudents()
    {
        return View(studentServices.GetAllStudents());
    }

    public IActionResult ShowDetails(int id)
    {
        return View(studentServices.GetStudent(id));
    }

    public string DeleteStudent(int id)
    {
        return studentServices.DeleteStudent(id);
    }

    public IActionResult UpdateStudent(int id)
    {
        return View(studentServices.GetStudent(id));
    }
    
    [HttpPost]
    public IActionResult UpdateStudentWithBinding(Student student)
    {
        return View(studentServices.UpdateStudent(student));
    }

    public IActionResult Index()
    {
        return View();
    }
}
