using Hosys.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Hosys.Data.IoC;

public static class DataDi
{
    public static void AddContextDi(this IServiceCollection service)
    {
        service.AddDbContext<ApplicationDbContext>();
    }
}