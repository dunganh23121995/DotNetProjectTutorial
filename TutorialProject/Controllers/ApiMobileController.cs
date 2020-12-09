using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialProject.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ApiMobileController : ControllerBase
    {
        [Route("anhmuongi")]
        [HttpGet]
        public string get() {
            return "123";
        }

    }
}
