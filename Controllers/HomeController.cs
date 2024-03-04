using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspOdev.Models;

namespace aspOdev.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Gezi()
    {
        return View();
    }
    public IActionResult Kategori()
    {
        return View();
    }
    public IActionResult Hakkımızda ()
    {
        return View();
    }
    public IActionResult İletisim ()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
