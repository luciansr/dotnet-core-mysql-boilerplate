using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromServices] UserService userService)
        {
            return Ok(userService.GetUsers());
        }

        // GET api/users/<id>
        [HttpGet("{id}")]
        public ActionResult<string> Get([FromServices] UserService userService, int id)
        {
            return Ok(userService.GetUserById(id));
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/users/<id>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/users/<id>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }
    }
}
