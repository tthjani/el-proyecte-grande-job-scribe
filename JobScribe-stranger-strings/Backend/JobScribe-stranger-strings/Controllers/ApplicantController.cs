using JobScribe_stranger_strings.Model;
using JobScribe_stranger_strings.Services.Repository;
using Microsoft.AspNetCore.Mvc;

namespace JobScribe_stranger_strings.Controllers;

[ApiController]
[Route("/api/[controller]")]
    
public class ApplicantController : ControllerBase
{
    private readonly ILogger<ApplicantController> _logger;
    private readonly IApplicantRepository _applicantRepository;
    
    public ApplicantController(ILogger<ApplicantController> logger, IApplicantRepository applicantRepository)
    {
        _logger = logger;
        _applicantRepository = applicantRepository;
    }

    [HttpGet("[action]")]
    public ActionResult GetAllApplicants()
    {
        var respond = new { res = _applicantRepository.GetAllApplicants() };
        return Ok(respond);
    }

    [HttpPost("[action]")]
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
    
    [HttpDelete("[action]")]
    public async Task<ActionResult<Applicant>> DeleteApplicant(int applicantID)
    {
        try
        {
            var applicant = _applicantRepository.GetApplicantById(applicantID);
            if (applicant == null)
            {
                return NotFound($"No applicant found!");
            }

            _applicantRepository.Delete(applicant);
            var response = new { res = $"Applicant {applicant.Name} has succesfully deleted" };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occured");
        }
    }

}