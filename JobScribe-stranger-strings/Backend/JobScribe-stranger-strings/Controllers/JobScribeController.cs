using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using JobScribe_stranger_strings.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Controllers;

[ApiController]
[Route("/api/[controller]")]
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
    
    [HttpGet("GetCompanyByName")]
    public async Task<ActionResult<Company>> GetCompanyByName(string companyName)
    {
        try
        {
            var company = _companyRepository.GetByName(companyName);

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
    
    [HttpPost("AddCompany")]
    public async Task<ActionResult<Company>> AddCompany(Company company)
    {
        try
        {
            if (company == null)
            {
                return BadRequest($"Please add a valid Company");
            }

            _companyRepository.Add(company);

            return Ok(company);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occured");
        }
    }
    
    [HttpDelete("DeleteCompany")]
    public async Task<ActionResult<Company>> DeleteCompany(string companyName)
    {
        try
        {
            var company = _companyRepository.GetByName(companyName);
            if (company == null)
            {
                return NotFound($"Company {companyName} not found");
            }

            _companyRepository.Delete(company);

            return Ok($"Company {company.Name} has succesfully deleted");
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occured");
        }
    }
    
}