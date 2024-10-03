using Microsoft.AspNetCore.Routing;
using System.Reflection;

namespace BuildingBlock
{
    public static class EndpointRouteBuilderExtensions
    {
        public static void MapAllEndpointsFromAssemblies(this IEndpointRouteBuilder app, params Assembly[] assemblies)
        {
            foreach (var assembly in assemblies)
            {
                var endpointTypes = assembly.GetTypes()
                    .Where(type => typeof(IRequestEndPoint).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

                foreach (var type in endpointTypes)
                {
                    var instance = Activator.CreateInstance(type) as IRequestEndPoint;

                    instance?.MapEndPoints(app);
                }
            }
        }
    }
}
