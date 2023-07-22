/*
 * IServiceCollection extension method:
 *  - add db context
 * File: ApplicationServiceExtensions.cs
 * Author: Sam
 * 
 */

using Microsoft.EntityFrameworkCore;
using ProductManagementApp.Data;

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


            return services;
        }
    }
}
