using Microsoft.AspNetCore.Mvc;

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
        return View();
    }
}
