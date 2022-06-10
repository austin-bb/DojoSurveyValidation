using System.ComponentModel.DataAnnotations;
namespace DojoSurveyValidation.Models;

public class Survey
{

    [Display(Name = "Name")]
    [Required]
    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Language { get; set; } = null!;

    [Display(Name = "Comment")]
    [MinLength(20, ErrorMessage = "must be at least 20 characters")]
    public string? Comment { get; set; }
}