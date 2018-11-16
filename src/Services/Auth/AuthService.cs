using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Models.Auth;

namespace Services.Auth
{
    public class AuthService
    {
        private readonly JwtConfig _jwtConfig;

        public AuthService(JwtConfig jwtConfig)
        {
            _jwtConfig = jwtConfig;
        }

        public bool UserAndPasswordAreValid(string username, string password)
        {
            return true;
        }

        public string BuildToken(string username, string password)
        {
            if (!UserAndPasswordAreValid(username, password)) return null;
            
            var claims = new[]
            {
                new Claim("Id", "1"),
                new Claim(ClaimTypes.Name, username)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}