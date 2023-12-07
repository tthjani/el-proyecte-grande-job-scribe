using Microsoft.AspNetCore.Mvc;

namespace JobScribe_stranger_strings.Controllers;

[ApiController]
[Route("[controller]")]
public class JobScribeController : ControllerBase
{
    private readonly ILogger<JobScribeController> _logger;

    public JobScribeController(ILogger<JobScribeController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Test")]
    public ActionResult Get()
    {
        var respond = new
        {
            res =
            "Successful connection to the server!"
        };
        return Ok(respond);
    }
}