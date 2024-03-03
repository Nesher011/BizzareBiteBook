namespace BizzareBiteBook.Domain.Entities;

public class Recipe : BaseAuditableEntity
{
    public string? Title { get; set; }
    public int Difficulty { get; set; }

    public int ListId { get; set; }
    public int TimeInMinutes { get; set; }
    public int NumberOfServings { get; set; }
    public string ImagePath { get; set; } = string.Empty;
    public IList<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public IList<Step> Steps { get; set; } = new List<Step>();
}
