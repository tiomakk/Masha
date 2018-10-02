using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masha.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Masha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlisaController : ControllerBase
    {
        [HttpPost("")]
        public void ProcessRequest([FromBody] AlisaRequestModel request)
        {

        }
    }
}