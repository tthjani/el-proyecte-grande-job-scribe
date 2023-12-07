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

    [HttpGet(Name = "GetJobs")]
    public IEnumerable<JobScribe> Get()
    {
        return null;
    }
}