using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TheBillboard.MVC.Models;
using TheBillboard.MVC.Gateway;

namespace TheBillboard.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly Gateways _gateway;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Form()
    {
        return View(_gateway.GetData());
    }

    public IActionResult MessageAuthor()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
