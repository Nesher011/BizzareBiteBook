using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizzareBiteBook.Application.Common.Models;
using BizzareBiteBook.Application.TodoLists.Queries.GetTodos;

namespace BizzareBiteBook.Application.Recipes.Queries.GetRecipes;

public class RecipesVm
{
    public IReadOnlyCollection<LookupDto> Units { get; init; } = Array.Empty<LookupDto>();

    public IReadOnlyCollection<RecipeDto> Recipes { get; init; } = Array.Empty<RecipeDto>();
}
