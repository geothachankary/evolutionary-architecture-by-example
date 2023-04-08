namespace SuperSimpleArchitecture.Fitnet.Passes.RegisterPass;

using Data;
using Data.Database;

internal static class RegisterEndpoint
{
    internal static void MapRegisterPass(this IEndpointRouteBuilder app)
    {
        app.MapPost(PassesApiPaths.Register, async (RegisterPassRequest request, PassesPersistence persistence) =>
        {
            var pass = Pass.Register(request.CustomerId, request.From, request.To);
            await persistence.Passes.AddAsync(pass);
            await persistence.SaveChangesAsync();

            return Results.Created($"/{PassesApiPaths.Register}/{pass.Id}", pass.Id);
        });
    }
}