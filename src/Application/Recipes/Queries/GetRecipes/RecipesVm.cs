using BizzareBiteBook.Application.Common.Models;

namespace BizzareBiteBook.Application.Recipes.Queries.GetRecipes;

public class RecipesVm
{
    public IReadOnlyCollection<LookupDto> Units { get; init; } = Array.Empty<LookupDto>();

    public IReadOnlyCollection<RecipeDto> Recipes { get; init; } = Array.Empty<RecipeDto>();
}
