using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers
{
    [ApiController]
    public class SimpleApi : ControllerBase
    {

        private readonly ILogger<SimpleApi> _logger;

        public SimpleApi(ILogger<SimpleApi> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("ping")]
        public string Get()
        {
            return $"Pong {DateTime.Now.ToLongDateString()}";
        }
    }
}
