using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using test.Models;

namespace test.Controllers;

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

    public IActionResult CreatePerson()
    {

        var model = new PersonViewModel
        {
            Name = "John Smith",
            Email = "joh.smith1234@icloud.com",
            Hobbies = new List<Hobby>
            {
                new Hobby {Name = "Football", Type = HobbyType.Outdoor},
                new Hobby {Name = "Swimming", Type = HobbyType.Indoor},
                new Hobby {Name = "Chess", Type = HobbyType.Indoor},
                new Hobby {Name = "Rugby", Type = HobbyType.Outdoor},
            }
        };


        return View(model);
    }

    [HttpPost]
    public IActionResult CreatePerson(PersonViewModel model)
    {
        if (!ModelState.IsValid)
        {
            // something went wrong
            return View(model);
        }

        // show results
        return View("Results", model);
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

