using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace vaultapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecretsController : ControllerBase
    {
    

        private readonly ILogger<SecretsController> _logger;

        public SecretsController(ILogger<SecretsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var rng = new Random();
            return "OK";
        }
    }
}
