/*
 * DEPRECATED: .net 5 Web Host Builder
 * update to .net 6
 */

#region Startup configure
/*
 * Configure class:
 * 1, configureService : 
 *      ConfigureService method takes IServiceCollection as an input parameter. 
 * 2, configure HTTP request processing pipeline:
 *      configure all the middleware. The Configure method takes two parameters.IApplicationBuilder and IWebHostEnvironment instance. 
 */

//using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

//namespace ProductManagementAPP.API
//{
//    public class Startup
//    {
//        private IConfiguration Configuration { get; }

//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        // Configure services
//        // Configure dependency injection
//        public void ConfigureServices(IServiceCollection services)
//        {
//            // Add DB service
//            services.AddApplicationServices(Configuration);

//            services.AddControllers();

//            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//            services.AddEndpointsApiExplorer();
//            services.AddSwaggerGen();

//            // #TODO: get knowledge to properly configure CORS.
//            //Enable cross-origin HTTP requests
//            services.AddCors();
//        }

//        // Configure application
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            // Configure the HTTP request pipeline.
//            app.UseSwagger();
//            app.UseSwaggerUI();

//            app.UseHttpsRedirection();

//            app.UseRouting();

//            app.UseAuthorization();

//            app.UseEndpoints(endpoints => {
//                endpoints.MapControllers();
//            });

//        }
//    }
//}

#endregion