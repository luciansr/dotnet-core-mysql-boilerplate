using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Services.Auth;

namespace Api.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("token")]
        [AllowAnonymous]
        public IActionResult Token(string username, string password, [FromServices]AuthService authService)
        {
            string token = authService.BuildToken(username, password);
            if (token == null) return Unauthorized();
            return Ok(token);
        }
        
        
    }
}