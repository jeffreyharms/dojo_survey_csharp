using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;

public class FormController : Controller
{
    [HttpGet("/form")]
    public ViewResult Form()
    {
        return View();
    }
    [HttpPost("/result")]
    public IActionResult Result(string Name, string Location, string Language, string Comments)
    {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Comments = Comments;
        return View();
    }
}