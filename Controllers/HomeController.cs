using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dotnet.Models;

namespace Dotnet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var list = new List <StudentVm>{
            new StudentVm(){id=1,Name="one",address="addr1"},
             new StudentVm(){id=2,Name="two",address="addr2"}
            //  commnt  
        };

        return View (list);
    }

    public IActionResult Privacy()
    {
        return View();
    } 
    public IActionResult about()
    {
        return View();
    }
     public IActionResult contact()
    {
        return View();
    }
    public IActionResult Test()
    {
        return View();
    }
    public IActionResult New(){
        return View(new TestVm());
    }
    [HttpPost]
    public IActionResult New(TestVm vm){
        return Ok(vm);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
