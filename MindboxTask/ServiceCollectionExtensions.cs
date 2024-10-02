using Microsoft.Extensions.DependencyInjection;
using MindboxLibrary.Circle;
using MindboxLibrary.Triangle;

namespace MindboxTask
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddShapeFactories(this IServiceCollection services)
        {
            services.AddTransient<ICircleFactory, CircleFactory>();
            services.AddTransient<ITriangleFactory, TriangleFactory>();
            return services;
        }
    }
}
