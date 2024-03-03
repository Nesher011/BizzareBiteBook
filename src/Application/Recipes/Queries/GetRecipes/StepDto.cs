using BizzareBiteBook.Domain.Entities;

namespace BizzareBiteBook.Application.Recipes.Queries.GetRecipes;

public class StepDto
{
    public int Id { get; init; }

    public int RecipeId { get; init; }

    public string? Description { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Step, StepDto>();
        }
    }
}
