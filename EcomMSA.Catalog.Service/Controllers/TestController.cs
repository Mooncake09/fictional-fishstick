using Microsoft.AspNetCore.Mvc;

namespace Catalog.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            return Ok(
            new
            {
                Message = "Hello from Catalog.Service!",
                Timestamp = DateTime.UtcNow,
                Service = "Catalog.Service"
            });
        }
    }
}
