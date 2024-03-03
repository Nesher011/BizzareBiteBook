using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizzareBiteBook.Application.Common.Interfaces;
using BizzareBiteBook.Application.TodoLists.Commands.DeleteTodoList;

namespace BizzareBiteBook.Application.Recipes.Commands.DeleteRecipe;
public record DeleteRecipeCommand(int Id) : IRequest;

public class DeleteRecipeCommandHandler(IApplicationDbContext context) : IRequestHandler<DeleteRecipeCommand>
{
    private readonly IApplicationDbContext _context = context;

    public async Task Handle(DeleteRecipeCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Recipes
            .Where(l => l.Id == request.Id)
            .SingleOrDefaultAsync(cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        _context.Recipes.Remove(entity);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
