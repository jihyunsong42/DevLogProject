using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devloggerWebAPI.Models;
using devloggerWebAPI.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace devloggerWebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DevLogController : ControllerBase
    {
        private IDevLogService _devLogService;
        public DevLogController(IDevLogService devLogService)
        {
            _devLogService = devLogService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DevLog>> Get()
        {
            return Ok(_devLogService.GetDevLogs());
        }

        


    }
}