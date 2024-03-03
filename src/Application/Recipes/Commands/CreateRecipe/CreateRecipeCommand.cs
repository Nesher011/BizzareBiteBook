using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizzareBiteBook.Application.Common.Interfaces;
using BizzareBiteBook.Application.TodoLists.Commands.CreateTodoList;
using BizzareBiteBook.Domain.Entities;

namespace BizzareBiteBook.Application.Recipes.Commands.CreateRecipe;

public record CreateRecipeCommand : IRequest<int>
{
    public string? Title { get; init; }
}

public class CreateRecipeCommandHandler(IApplicationDbContext context) : IRequestHandler<CreateRecipeCommand, int>
{
    private readonly IApplicationDbContext _context = context;

    public async Task<int> Handle(CreateRecipeCommand request, CancellationToken cancellationToken)
    {
        var entity = new Recipe
        {
            Title = request.Title
        };

        _context.Recipes.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
