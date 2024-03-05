using BizzareBiteBook.Application.Common.Models;
using BizzareBiteBook.Application.Recipes.Commands.CreateRecipe;
using BizzareBiteBook.Application.Recipes.Commands.DeleteRecipe;
using BizzareBiteBook.Application.Recipes.Commands.UpdateRecipe;


namespace BizzareBiteBook.Web.Endpoints;

public class Recipes : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            //.MapGet(GetTodoItemsWithPagination)
            .MapPost(CreateRecipe)
            .MapPut(UpdateRecipe, "{id}")
            //.MapPut(UpdateRecipeDetail, "UpdateDetail/{id}")
            .MapDelete(DeleteRecipe, "{id}");
    }

    //public async Task<PaginatedList<TodoItemBriefDto>> GetTodoItemsWithPagination(ISender sender, [AsParameters] GetTodoItemsWithPaginationQuery query)
    //{
    //    return await sender.Send(query);
    //}

    public async Task<int> CreateRecipe(ISender sender, CreateRecipeCommand command)
    {
        return await sender.Send(command);
    }

    public async Task<IResult> UpdateRecipe(ISender sender, int id, UpdateRecipeCommand command)
    {
        if (id != command.Id) return Results.BadRequest();
        await sender.Send(command);
        return Results.NoContent();
    }

    //public async Task<IResult> UpdateRecipeDetail(ISender sender, int id, UpdateRecipeDetailCommand command)
    //{
    //    if (id != command.Id) return Results.BadRequest();
    //    await sender.Send(command);
    //    return Results.NoContent();
    //}

    public async Task<IResult> DeleteRecipe(ISender sender, int id)
    {
        await sender.Send(new DeleteRecipeCommand(id));
        return Results.NoContent();
    }
}
