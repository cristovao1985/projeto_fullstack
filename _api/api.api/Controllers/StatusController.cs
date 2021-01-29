using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public JsonResult Get()
        {
            return new JsonResult(DateTime.Now);

        }
    }
}
