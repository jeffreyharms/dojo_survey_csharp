#pragma warning disable CS8618
namespace DojoSurvey.Models;

using System.ComponentModel.DataAnnotations;

public class Form
{
    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
    public string Name { get; set; }
    [Required(ErrorMessage = "is required")]
    public string Location { get; set; }
    [Required(ErrorMessage = "is required")]
    public string Language { get; set; }
    [MinLength(20, ErrorMessage = "must be at least 20 characters")]
    public string? Comments { get; set; }
}