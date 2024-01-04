using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    [HttpGet("GetCompany")]
    public async Task<ActionResult<Company>> GetCompany(string companyName)
    {
        try
        {
            await using var dbContext = new JobScribeContext();
            var company = dbContext.Companies.FirstOrDefault(c => c.Name == companyName);

            if (company == null)
            {
                return NotFound($"Company {companyName} not found");
            }

            return Ok(company);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occured");
        }
    }
}