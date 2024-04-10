using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CurrentTimeAndDay.Models;

namespace CurrentTimeAndDay.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Asia()
    {
        return View();
    }

    public IActionResult Africa()
    {
        return View();
    }

    public IActionResult NorthAmerica()
    {
        return View();
    }

    public IActionResult SouthAmerica()
    {
        return View();
    }

    public IActionResult Europe()
    {
        return View();
    }

    public IActionResult AustraliaAndOceania()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

