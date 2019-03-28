using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace validation.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] PersonDto person)
        {
            // If the PersonDto does not pass the validation, the request will have a 400 response
            // that follows the Problem Description format specified in RFC 7807
        }
    }
}
