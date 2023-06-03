using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Lasmart.Business.Services;
using Lasmart.Business.Interfaces;

namespace Lasmart.Business.DependecyResolver;

public static class RegisterBusiness
{
    public static void RegisterBusinessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddScoped<ICircleService, CircleService>();

        services.AddScoped<ICommentService, CommentService>();
    }
}