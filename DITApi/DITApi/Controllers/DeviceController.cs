using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DITApi.Models;
using Microsoft.AspNetCore.Http;

namespace DITApi.Controllers
{
    [ApiController]
    [Route("api/device/")]
    public class DeviceController  : ControllerBase
    {
        private readonly ILogger<DeviceController> _logger;

        public DeviceController(ILogger<DeviceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetDevice(string id)
        {
            Device newDev = new Device(id);
            string[] results = { "test", "test" };
            results[0] = newDev.DevDTO.DeviceName;
            return Ok("devicename:" + results[0]);
        }
    }
}
