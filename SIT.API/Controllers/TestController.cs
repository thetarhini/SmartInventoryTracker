using Microsoft.AspNetCore.Mvc;

namespace SIT.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Smart Inventory Tracker API is running!", timestamp = DateTime.UtcNow });
        }

        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok(new { status = "Healthy", service = "Smart Inventory Tracker API" });
        }
    }
} 