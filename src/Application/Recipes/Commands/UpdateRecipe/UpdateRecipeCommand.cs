using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizzareBiteBook.Application.Common.Interfaces;
using BizzareBiteBook.Application.TodoLists.Commands.UpdateTodoList;

namespace BizzareBiteBook.Application.Recipes.Commands.UpdateRecipe;
public record UpdateRecipeCommand : IRequest
{
    public int Id { get; init; }

    public string? Title { get; init; }
}

public class UpdateRecipeCommandHandler(IApplicationDbContext context) : IRequestHandler<UpdateRecipeCommand>
{
    private readonly IApplicationDbContext _context = context;

    public async Task Handle(UpdateRecipeCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Recipes
            .FindAsync(new object[] { request.Id }, cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        entity.Title = request.Title;

        await _context.SaveChangesAsync(cancellationToken);
    }
}
