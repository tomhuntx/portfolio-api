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
        public UserInformation Get()
        {
            return new()
            {
                Date = DateTime.Now,
                TotalVisits = 1
            };
        }
    }
}