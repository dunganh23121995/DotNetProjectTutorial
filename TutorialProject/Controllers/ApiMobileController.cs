using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiMobileController : ControllerBase
    {
        [Route("get")]
        public string get() {
            return "123";
        }

    }
}
