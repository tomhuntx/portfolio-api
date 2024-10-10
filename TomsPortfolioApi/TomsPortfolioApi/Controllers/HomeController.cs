using Microsoft.AspNetCore.Mvc;

namespace TomsPortfolioApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("stats")]
        public UserInformation GetSiteStatistics()
        {
            return new()
            {
                Date = DateTime.Now,
                TotalVisits = 1
            };
        }
    }
}