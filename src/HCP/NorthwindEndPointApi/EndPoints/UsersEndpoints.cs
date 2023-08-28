using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using NorthwindEndPointApi.Entities;
namespace NorthwindEndPointApi.EndPoints;

public static class UsersEndpoints
{
    public static void MapusersEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/users").WithTags(nameof(users));

        group.MapGet("/", async (NorthwindContext db) =>
        {
            return await db.users.ToListAsync();
        })
        .WithName("GetAllusers")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<users>, NotFound>> (int id, NorthwindContext db) =>
        {
            return await db.users.AsNoTracking()
                .FirstOrDefaultAsync(model => model.id == id)
                is users model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetusersById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, users users, NorthwindContext db) =>
        {
            var affected = await db.users
                .Where(model => model.id == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.id, users.id)
                  .SetProperty(m => m.name, users.name)
                  .SetProperty(m => m.age, users.age)
                  .SetProperty(m => m.location, users.location)
                  .SetProperty(m => m.createdat, users.createdat)
                  .SetProperty(m => m.createdby, users.createdby)
                  .SetProperty(m => m.updatedat, users.updatedat)
                  .SetProperty(m => m.updatedby, users.updatedby)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("Updateusers")
        .WithOpenApi();

        group.MapPost("/", async (users users, NorthwindContext db) =>
        {
            db.users.Add(users);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/users/{users.id}",users);
        })
        .WithName("Createusers")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, NorthwindContext db) =>
        {
            var affected = await db.users
                .Where(model => model.id == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("Deleteusers")
        .WithOpenApi();
    }
}
