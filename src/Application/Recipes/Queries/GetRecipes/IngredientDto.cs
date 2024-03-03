using BizzareBiteBook.Application.TodoLists.Queries.GetTodos;
using BizzareBiteBook.Domain.Entities;

namespace BizzareBiteBook.Application.Recipes.Queries.GetRecipes;

public class IngredientDto
{
    public int Id { get; init; }

    public int RecipeId { get; init; }

    public string? Name { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Ingredient, IngredientDto>();
        }
    }
}
