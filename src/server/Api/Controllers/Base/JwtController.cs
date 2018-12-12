using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Models.Auth;

namespace Api.Controllers.Base
{
    public class JwtController : ControllerBase
    {
        protected AuthenticatedUser AuthenticatedUser {
            get
            {
                return new AuthenticatedUser()
                {
                    Id = Int32.Parse(this.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value),
                    Name = this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value
                };
            }
        }
    }
}