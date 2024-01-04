using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using JobScribe_stranger_strings.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Controllers;

[ApiController]
[Route("[controller]")]
public class JobScribeController : ControllerBase
{
    private readonly ILogger<JobScribeController> _logger;
    private readonly ICompanyRepository _companyRepository;

    public JobScribeController(ILogger<JobScribeController> logger, ICompanyRepository companyRepository)
    {
        _logger = logger;
        _companyRepository = companyRepository;
    }

    [HttpGet("GetAllCompanies")]
    public ActionResult GetAllCompanies()
    {
        var respond = _companyRepository.GetAll(); 
        return Ok(respond);
    }
    
}