using JobScribe_stranger_strings.Model;
using JobScribe_stranger_strings.Services.Repository;
using Microsoft.AspNetCore.Mvc;

namespace JobScribe_stranger_strings.Controllers;

[ApiController]
[Route("/api/[controller]/[action]")]
    
public class ApplicantController : ControllerBase
{
    private readonly ILogger<ApplicantController> _logger;
    private readonly IApplicantRepository _applicantRepository;
    
    
    public ApplicantController(ILogger<ApplicantController> logger, IApplicantRepository applicantRepository)
    {
        _logger = logger;
        _applicantRepository = applicantRepository;
    }

    [HttpGet("")]
    public ActionResult GetAllApplicants()
    {
        var response = new { res = _applicantRepository.GetAllApplicants() };
        return Ok(response);
    }

    [HttpPost("")]
    public ActionResult AddApplicant(Applicant applicant)
    {
        try
        {
            if (applicant == null)
            {
                return BadRequest("Please add a valid Applicant");
            }
            
            _applicantRepository.Add(applicant);
            var response = new { res = applicant };
            return Ok(response);
        }
        
        catch (Exception e)
        {
            return StatusCode(500, "An error occured");
        }      
    }
    
    [HttpDelete("")]
    public ActionResult DeleteApplicant(int applicantId)
    {
        try
        {
            var applicant =  _applicantRepository.GetApplicantById(applicantId);
            if (applicant == null)
            {
                return NotFound($"No applicant found!");
            }

            _applicantRepository.Delete(applicant);
            var response = new { res = $"Applicant {applicant.Name} has successfully deleted" };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occured");
        }
    }

}