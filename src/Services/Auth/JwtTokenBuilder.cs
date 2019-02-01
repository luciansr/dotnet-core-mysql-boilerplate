using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Models.Auth;

namespace Services.Auth
{
    public class JwtTokenBuilder
    {
        private readonly JwtConfig _jwtConfig;

        public JwtTokenBuilder(JwtConfig jwtConfig)
        {
            _jwtConfig = jwtConfig;
        }
        public string BuildToken(DateTime issuedAt, int expirationInMinutes, Claim[] claims = null)
        {
            if (claims == null)
            {
                claims = new Claim[0];
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                claims: claims,
                notBefore: issuedAt,
                expires: issuedAt.AddMinutes(expirationInMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}