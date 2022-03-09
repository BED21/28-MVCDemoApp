using Microsoft.AspNetCore.Mvc;

using MVCDemo.Models;

namespace MVCDemo.Controllers;

public class FirstController : Controller
{
    public string Index()
    {
        //return View();
        return "Hello World!!";
    }

    public IActionResult Hello()
    {
        ViewBag.Message = "Hello world";
        return View();
    }

    public IActionResult Info()
    {
        Person person = new Person()
        {
            Id = 1,
            Name = "Claes",
            Age = 65,
            Location = "Göteborg"
        };

        return View(person);
    }
}
