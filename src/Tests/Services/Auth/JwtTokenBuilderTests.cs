using System;
using Xunit;
using Services.Auth;
using Models.Auth;
using Moq;
using System.Security.Claims;

namespace Tests.Services.Auth
{
    public class JwtTokenBuilderTests
    {
        [Fact]
        public void UnitTest1()
        {
            JwtConfig jwtConfig = new JwtConfig
            {
                Audience = "audience",
                Issuer = "issuer",
                SecretKey = "your-256-bit-my-ultra-secret-key-your-256-bit-my-ultra-secret-key"
            };

            Claim[] claims = new Claim[] {
                new Claim("name", "John Doe")
            };

            JwtTokenBuilder jwtTokenBuidler = new JwtTokenBuilder(jwtConfig);
            DateTime issuedAt = DateTime.Parse("2019-01-01", System.Globalization.CultureInfo.InvariantCulture);

            String expected = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9"
                            + ".eyJuYW1lIjoiSm9obiBEb2UiLCJuYmYiOjE1NDYzMDgwMDAsImV4cCI6MTU0NjMwODEyMCwiaXNzIjoiaXNzdWVyIiwiYXVkIjoiYXVkaWVuY2UifQ"
                            + ".B6fe0ib4gLKKU27Ks6kc8yuVDErzwWUdQJnmvk3p3pU";

            string jwt = jwtTokenBuidler.BuildToken(issuedAt, expirationInMinutes: 2, claims: claims);

            Assert.Equal(expected, jwt);
        }
    }
}