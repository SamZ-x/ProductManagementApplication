/*
 * DEPRECATED: .net 5 Web Host Builder
 * update to .net 6
 */

# region Web Host old version
//namespace ProductManagementAPP.API
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            CreateHostBuilder(args).Build().Run();
//        }

//        public static IHostBuilder CreateHostBuilder(string[] args) =>
//            Host.CreateDefaultBuilder(args)
//                .ConfigureWebHostDefaults(webBuilder =>
//                {
//                    webBuilder.UseStartup<Startup>();
//                });
//    }
//}

#endregion

/*
 * .net 6 host
 */

using ProductManagementAPP.API;

var builder = WebApplication.CreateBuilder(args);

# region services container

/***** Add services to the container. *****/

// DB services.
builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerDocument(configure => configure.Title = "Product Management API");

// Authentication
builder.Services.AddIdentityServices(builder.Configuration);

// #TODO: get knowledge to properly configure CORS.
// Enable cross-origin HTTP requests
builder.Services.AddCors();

#endregion

var app = builder.Build();

# region Configure HTTP request pipeline.

// Configure the HTTP request pipeline.

//if (app.Environment.IsDevelopment()) {}

app.UseOpenApi();
app.UseSwaggerUI();

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));

app.UseHttpsRedirection();


app.UseAuthentication();

// User identity verification
app.UseAuthorization();

app.MapControllers();

#endregion

app.Run();


