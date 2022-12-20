using Microsoft.AspNetCore.Mvc;

namespace serialization.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IFoo _foo;

    public WeatherForecastController(IFoo foo)
    {
        _foo = foo;
    }

    [HttpGet("Foo")]
    public IActionResult GetFoo()
    {
        return Ok(_foo.Values);
    }


}
