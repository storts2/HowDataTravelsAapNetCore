using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WK_5_DataTravelControllerToView.Models;
using WK_5_DataTravelControllerToView.Models.ViewModel;

namespace WK_5_DataTravelControllerToView.Controllers;

public class HomeController : Controller
{
    private readonly Student student = new Student
    {
        Id = 1,
        Name = "Frank",
        Grade = 88.88
    };

    public IActionResult DemoViewData()
    {
        ViewData["Greetings"] = "Hello, from View data (Weakly Typed Dictionary)";
        ViewData["Student"] = student;

        ViewBag.Grettings = "Hello, from View Bag (Dynamic Wrapper)";
        ViewBag.Student = student;

        var test = new ViewModelDemo();

        // Only one object can be sent to the view
        return View(test);
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
