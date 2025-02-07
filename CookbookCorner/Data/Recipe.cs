using System.ComponentModel.DataAnnotations;

namespace CookbookCorner.Data;

public class Recipe
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }
}
