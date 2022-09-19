using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sibintek_test_task.Data.interfaces;
using sibintek_test_task.Models;

namespace sibintek_test_task.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ISibintekFile _iSibintekFile;


    public HomeController(ISibintekFile iSibintekFile,  ILogger<HomeController> logger)
    {
        _iSibintekFile = iSibintekFile;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public JsonResult GetFileStructure() {
        var files = _iSibintekFile.allFiles;
        return Json(files);
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
