/*
 * IServiceCollection extension method:
 *  - add db context
 * File: ApplicationServiceExtensions.cs
 * Author: Sam
 * 
 */

using Microsoft.EntityFrameworkCore;
using ProductManagementApp.API.Services.Implementation;
using ProductManagementApp.API;
using ProductManagementApp.Data;
using ProductManagementApp.DataUtility;

namespace ProductManagementAPP.API
{
    public static class ApplicationServiceExtensions 
    {
        //Extend the IServiceCollection, require configuration as param
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            //Add sqlServer 
            services.AddDbContext<PMDataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            // DI: add services.
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddAutoMapper(typeof(MappingConfiguration));
            return services;
        }
    }
}
