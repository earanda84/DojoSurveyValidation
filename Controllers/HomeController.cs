using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers;

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
    [HttpGet("results")]
    public IActionResult Results()
    {
        return View();
    }

    [HttpPost("results")]
    public IActionResult Results(Survey survey)
    {

        if (ModelState.IsValid)
        {
            Console.WriteLine(survey.Name);
            Console.WriteLine(survey.Location);
            Console.WriteLine(survey.Language);
            Console.WriteLine(survey.Comment);
            return View("Results", survey);
        }
        else
        {
            return View("Index");
        }
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
