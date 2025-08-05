using Microsoft.AspNetCore.Mvc;

namespace SIT.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new 
            { 
                message = "Welcome to Smart Inventory Tracker API",
                version = "1.0.0",
                endpoints = new
                {
                    swagger = "/swagger",
                    test = "/api/test",
                    health = "/api/test/health"
                },
                timestamp = DateTime.UtcNow
            });
        }
    }
} 