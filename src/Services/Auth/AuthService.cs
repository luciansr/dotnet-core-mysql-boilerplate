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
        private JwtTokenBuilder _jwtTokenBuilder;

        public AuthService(JwtTokenBuilder jwtTokenBuilder)
        {
            _jwtTokenBuilder = jwtTokenBuilder;
        }

        public bool UserAndPasswordAreValid(string username, string password)
        {
            return true;
        }

        public Claim[] GetUserClaims(String username)
        {
            return new []
            {
                new Claim("Id", "1"),
                new Claim(ClaimTypes.Name, username)
            };
        }

        public string BuildToken(string username, string password)
        {
            if (!UserAndPasswordAreValid(username, password))
            {
                return null;
            }
            
            return _jwtTokenBuilder.BuildToken(DateTime.Now, 30, GetUserClaims(username));
        }
    }
}