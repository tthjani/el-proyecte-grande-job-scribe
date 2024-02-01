using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using JobScribe_stranger_strings.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Controllers;

[ApiController]
[Route("/api/[controller]/[action]")]
public class CompanyController : ControllerBase
{
    private readonly ILogger<CompanyController> _logger;
    private readonly ICompanyRepository _companyRepository;

    public CompanyController(ILogger<CompanyController> logger, ICompanyRepository companyRepository)
    {
        _logger = logger;
        _companyRepository = companyRepository;
    }

    [HttpGet]
    public ActionResult Test()
    {
        {
            var respond = new { res= "Successfully connected to the server!" };
            return Ok(respond);
        }
    }


    [HttpGet, Authorize(Roles="User, Admin, Company")]
    public ActionResult GetAllCompanies()
    {
        var respond =new {res=_companyRepository.GetAll()};
        
        return Ok(respond);
    }
    

    [HttpGet, Authorize(Roles="Admin")]
    public async Task<ActionResult<Company>> GetCompanyByName(string companyName)
    {
        try
        {
            var company = new {res=_companyRepository.GetByName(companyName)};

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
    
    [HttpPost]
    public async Task<ActionResult<Company>> AddCompany(Company company)
    {
        try
        {
            if (company == null)
            {
                return BadRequest($"Please add a valid Company");
            }

            _companyRepository.Add(company);
            var response = new { res = company };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occured");
        }
    }
    
    [HttpDelete]
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
            var response = new { res = $"Company {company.Name} has succesfully deleted" };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occured");
        }
    }
    
}