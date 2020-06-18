using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi_k8s.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PodInfoController : ControllerBase
    {
        private readonly ILogger<ServerInfoController> _logger;

        public PodInfoController(ILogger<ServerInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ServerInfo Get()
        {            
            return new ServerInfo(1);
        }
    }
}
