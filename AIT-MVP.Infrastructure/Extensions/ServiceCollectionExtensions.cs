using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AIT_MVP.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructureMappings(this IServiceCollection services)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
