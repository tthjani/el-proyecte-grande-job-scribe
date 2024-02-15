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
    private readonly ICvModelRepository _cvModelRepository;


    public ApplicantController(ILogger<ApplicantController> logger, IApplicantRepository applicantRepository,
        ICvModelRepository cvModelRepository)
    {
        _logger = logger;
        _applicantRepository = applicantRepository;
        _cvModelRepository = cvModelRepository;
    }


    [HttpGet]
    public ActionResult GetAllApplicants()
    {
        var respond =  new { res = _applicantRepository.GetAllApplicants() };
        return Ok(respond);
    }

    [HttpPost]
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


    [HttpDelete]
    public async Task<ActionResult<Applicant>> DeleteApplicant(int applicantID)
    {
        try
        {
            var applicant = await _applicantRepository.GetApplicantById(applicantID);

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

    [HttpPatch]
    public async Task<ActionResult<Company>> PatchCompany(int id, ApplicantUpdate updatedApplicant)
    {
        try
        {
            var company = await _applicantRepository.Update(id, updatedApplicant);
            if (company == null)
            {
                return NotFound($"Company with ID {id} not found");
            }

            return Ok(company);
        }
        catch (Exception ex)
        { 
            return StatusCode(500, "An error occurred");
        }
    }
    
    [HttpPost]
    public ActionResult AddCV(CVModel cvModel)
    {
        try
        {
            if (cvModel == null)
            {
                return BadRequest("Please add a valid Applicant");
            }
            
            _cvModelRepository.Add(cvModel);
            var response = new { res = cvModel };
            return Ok(response);
        }
        
        catch (Exception e)
        {
            return StatusCode(500, "An error occured");
        }      
    }
}