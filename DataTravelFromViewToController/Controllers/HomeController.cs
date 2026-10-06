using DataTravelFromViewToController.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;

namespace DataTravelFromViewToController.Controllers;

public class HomeController : Controller
{
    public string UsingModelBinding(Student student)
    {
        return $"Hello, {student.Name}, your id is {student.Id} and grade is {student.Grade}";
    }

    public string UsingFormCollection(IFormCollection form)
    {
        int id = Convert.ToInt32(form["id"]);
        string name = form["name"];
        double grade = Convert.ToDouble(form["grade"]);

        return $"Hello, {name}, your id is {id} and grade is {grade}";
    }

    public string UsingParameters(int id, string name, double grade)
    {
        return $"Hello, {name}, your id is {id} and grade is {grade}";
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
