namespace BizzareBiteBook.Domain.Entities;

public class Ingredient : BaseAuditableEntity
{
    public string? Name { get; set; }

    public int? AmountOf { get; set; }

    public Unit? Unit { get; set; }
    public bool IsMandatory { get; set; }
}
