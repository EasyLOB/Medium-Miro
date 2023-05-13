using Microsoft.AspNetCore.Mvc;

namespace my_api.Controllers;

public class MiroController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Miro()
    {
        return View();
    }
}
