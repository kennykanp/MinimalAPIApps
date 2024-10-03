
using BuildingBlock;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;


namespace ModuleOne
{
    public class EndPoints : IRequestEndPoint
    {
        public IEndpointRouteBuilder MapEndPoints(IEndpointRouteBuilder app)
        {
            app.MapGet("/module-one/info", () =>
            {
                return Results.Ok("This is Module One");
            }).WithName("Module One")
            .WithTags("Module Onw")
            .Produces(201)
            .ProducesProblem(400);

            return app;
        }
    }
}
