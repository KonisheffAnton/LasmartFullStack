using DataAccessLayer.Repositories;
using Lasmart.Core.Interfaces;
using Lasmart.DataAccessLayer.Entities;
using Lasmart.DataAccessLayer.Helpers;
using Lasmart.DataAccessLayer.Interfaces;
using Lasmart.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lasmart.DataAccessLayer.DatabaseSetter
{
    public static class IServiceCollectionsExtensions
    {
        public static void RegisterDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            var appDbConnectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(appDbConnectionString));
            services.AddScoped<IRepositoryBase<CircleEntity>, CircleRepository>();
            services.AddScoped<IRepositoryBase<CommentEntity>, CommentRepository>();
            services.AddScoped<IUnitOfWork, ApplicationUnitOfWork>();
            services.AddTransient<DbInitializer>();
        }
    }
}
