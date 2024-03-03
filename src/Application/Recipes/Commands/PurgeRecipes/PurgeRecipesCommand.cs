using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizzareBiteBook.Application.Common.Interfaces;
using BizzareBiteBook.Application.Common.Security;
using BizzareBiteBook.Domain.Constants;

namespace BizzareBiteBook.Application.Recipes.Commands.PurgeRecipes;
[Authorize(Roles = Roles.Administrator)]
[Authorize(Policy = Policies.CanPurge)]
public record PurgeRecipesCommand : IRequest;

public class PurgeRecipesCommandHandler(IApplicationDbContext context) : IRequestHandler<PurgeRecipesCommand>
{
    private readonly IApplicationDbContext _context = context;

    public async Task Handle(PurgeRecipesCommand request, CancellationToken cancellationToken)
    {
        _context.Recipes.RemoveRange(_context.Recipes);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
