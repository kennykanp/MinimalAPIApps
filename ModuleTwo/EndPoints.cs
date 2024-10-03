using BuildingBlock;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace ModuleTwo
{
    public class EndPoints : IRequestEndPoint
    {
        public IEndpointRouteBuilder MapEndPoints(IEndpointRouteBuilder app)
        {
            app.MapGet("/module-two/info", () =>
            {
                return Results.Ok("This is Module Two");
            }).WithName("Module Two")
               .WithTags("Module Twot")
               .Produces(201)
               .ProducesProblem(400);

            return app;
        }
    }
}
