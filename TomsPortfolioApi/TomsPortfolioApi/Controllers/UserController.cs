using Microsoft.AspNetCore.Mvc;

namespace TomsPortfolioApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
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