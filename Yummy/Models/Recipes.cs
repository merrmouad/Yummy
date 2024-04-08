using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yummy.Models;

public class Recipes
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Time { get; set; }
    public string? Difficulty { get; set; }
    [Display(Name = " Number of likes")]
    public int Number_of_likes { get; set; }
    public string? Ingredients { get; set; }
    public string? Process { get; set; }
    [Display(Name = "Tips and Tricks")]
    public string? Tips_and_Tricks { get; set; }
}
