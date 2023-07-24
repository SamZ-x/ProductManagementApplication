/*
 * IServiceCollection extension method:
 *  - add JWT authentication
 * File: IdentityServiceExtensions.cs
 * Author: Sam
 * 
 */

namespace ProductManagementAPP.API
{
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.IdentityModel.Tokens;
    using System.Text;

    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            // Jwt authentication 
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"])),
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            // Extra Authorization policies
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminAccess", policy => policy
                .RequireClaim("Role", "Admin"));
            });

            return services;
        }
    }
}
