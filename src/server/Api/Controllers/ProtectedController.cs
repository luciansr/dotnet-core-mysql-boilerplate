using System;
using System.Collections.Generic;
using System.Linq;
using Api.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtectedController : JwtController
    {
        /// <summary>
        /// To access this method use Bearer Token Auth with the Jwt Token acquired from "/token" endpoint 
        /// </summary>
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { this.AuthenticatedUser.Id.ToString(), this.AuthenticatedUser.Name };
        }

    }
}