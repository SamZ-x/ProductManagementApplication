using Microsoft.IdentityModel.Tokens;
using ProductManagementApp.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProductManagementApp.API.Services.Implementation
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _key;

        public TokenService(IConfiguration configuration) 
        {
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"]));
        }

        /// <summary>
        /// Create JWT token base on the user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.NameId, user?.Username),
                new Claim(JwtRegisteredClaimNames.Email, user?.Email),
                new Claim("Role", user.Role.ToString())
            };

            SigningCredentials creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

            SecurityTokenDescriptor tokeDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokeDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
