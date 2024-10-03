using Microsoft.AspNetCore.Routing;

namespace BuildingBlock
{
    public interface IRequestEndPoint
    {
        IEndpointRouteBuilder MapEndPoints(IEndpointRouteBuilder app);
    }
}
