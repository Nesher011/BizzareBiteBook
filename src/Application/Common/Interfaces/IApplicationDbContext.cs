using BizzareBiteBook.Domain.Entities;

namespace BizzareBiteBook.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<Recipe> Recipes { get; }
    DbSet<Ingredient> Ingredients { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
