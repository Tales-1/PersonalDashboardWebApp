using Microsoft.AspNetCore.Mvc;
using PersonalDashboardAppProj.Models;
using System.Diagnostics;

namespace PersonalDashboardAppProj.Controllers;

public class MyAppsController : Controller
{
    private readonly ILogger<MyAppsController> _logger;

    public MyAppsController(ILogger<MyAppsController> logger)
    {
        _logger = logger;
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