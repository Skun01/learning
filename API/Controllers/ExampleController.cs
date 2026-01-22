using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("example")]
public class ExampleController : ControllerBase
{
    [HttpGet("greeting")]
    public IActionResult Example()
    {
        return Ok("Hello world");
    }
}
