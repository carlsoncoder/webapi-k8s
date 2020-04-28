using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi_k8s.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerInfoController : ControllerBase
    {
        private readonly ILogger<ServerInfoController> _logger;

        public ServerInfoController(ILogger<ServerInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ServerInfo Get()
        {            
            var rng = new Random();
            int id = rng.Next(1, 100);

            if (id % 5 == 0)
            {
                throw new ApplicationException($"Invalid ServerInfo ID: {id}");
            }
            else
            {
                var serverInfo = new ServerInfo(id);
                this._logger.LogInformation($"Successfully processed ServerInfo with ID: {id}");
                return new ServerInfo(id);
            }
        }
    }
}
