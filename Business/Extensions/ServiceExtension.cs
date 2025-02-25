using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Extensions;

public static class ServiceExtension
{
    public static void AddApplicationExtensions(this IServiceCollection services)
    {
        services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}