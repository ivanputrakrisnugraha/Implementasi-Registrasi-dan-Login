using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _72220556sampleWebApp.Models;

namespace _72220556sampleWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //ViewData["Username"] = "Ivan putra Krisnugraha";
        ViewBag.Username = "IVAN PUTRA KRISNUGRAHA";
        string[] fruits = new string[] {"Universitas Kristen DutaWacana","Indonesia", "Laki Laki"};
        ViewBag.fruits = fruits;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
          ViewData["Title"] = "About page";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
