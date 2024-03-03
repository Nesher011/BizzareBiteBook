using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizzareBiteBook.Application.TodoLists.Queries.GetTodos;
using BizzareBiteBook.Domain.Entities;

namespace BizzareBiteBook.Application.Recipes.Queries.GetRecipes;

public class RecipeDto
{
    public RecipeDto()
    {
        Ingredients = Array.Empty<IngredientDto>();
        Steps = Array.Empty<StepDto>();
    }

    public int Id { get; init; }

    public string? Title { get; init; }

    public Unit Unit { get; init; }

    public IReadOnlyCollection<IngredientDto> Ingredients { get; init; }
    public IReadOnlyCollection<StepDto> Steps { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Recipe, RecipeDto>();
        }
    }
}
