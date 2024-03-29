﻿using BizzareBiteBook.Application.Common.Interfaces;
using BizzareBiteBook.Application.Common.Models;
using BizzareBiteBook.Application.Common.Security;
using BizzareBiteBook.Domain.Enums;
using MediatR;
using Unit = BizzareBiteBook.Domain.Enums.Unit;

namespace BizzareBiteBook.Application.Recipes.Queries.GetRecipes;

[Authorize]
public record GetRecipesQuery : IRequest<RecipesVm>;

public class GetRecipesQueryHandler(IApplicationDbContext context, IMapper mapper) : IRequestHandler<GetRecipesQuery, RecipesVm>
{
    private readonly IApplicationDbContext _context = context;
    private readonly IMapper _mapper = mapper;

    public async Task<RecipesVm> Handle(GetRecipesQuery request, CancellationToken cancellationToken)
    {
        return new RecipesVm()
        {
            Units = Enum.GetValues(typeof(Unit))
                .Cast<Unit>()
                .Select(p => new LookupDto { Id = (int)p, Title = p.ToString() })
                .ToList(),
            Recipes = await _context.Recipes
                .AsNoTracking()
                .ProjectTo<RecipeDto>(_mapper.ConfigurationProvider)
                .OrderBy(t => t)
                .ToListAsync(cancellationToken)
        };
    }
}
