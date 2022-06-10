using System.Diagnostics;
using DojoSurveyValidation.Models;
using Microsoft.AspNetCore.Mvc;


namespace DojoSurveyValidation.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost("submit")]
    public IActionResult Submit(Survey user)
    {
      if (ModelState.IsValid)
      {
        return RedirectToAction("Result", user);
      }
      else 
      {
        return View("Index");
      }
    }

    [HttpGet("result")]
    public IActionResult Result(Survey user)
    {
      return View("Result", user);
    }
}
