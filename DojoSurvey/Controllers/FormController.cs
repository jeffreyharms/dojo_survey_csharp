using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
namespace DojoSurvey.Controllers;

public class FormController : Controller
{
    [HttpGet("/form")]
    public ViewResult Form()
    {
        return View();
    }
    [HttpPost("/result")]
    public IActionResult Result(Form newForm)
    {
        if(ModelState.IsValid) {
            return View("Result", newForm);
        }
        else {
            return View("Form");
        }
    }
}