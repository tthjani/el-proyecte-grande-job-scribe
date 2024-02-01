using JobScribe_stranger_strings.Model;
using JobScribe_stranger_strings.Services.Repository;
using Microsoft.AspNetCore.Mvc;

namespace JobScribe_stranger_strings.Controllers;

[ApiController]
[Route("/api/[controller]/[action]")]

public class ServiceController : ControllerBase
{
    private readonly ILogger<CompanyController> _logger;
    private readonly ILanguageRepository _languageRepository;
    private readonly IMustHavesRepository _mustHavesRepository;
    private readonly INiceToHaveRepository _niceToHaveRepository;

    public ServiceController(ILogger<CompanyController> logger, ILanguageRepository languageRepository, IMustHavesRepository mustHavesRepository, INiceToHaveRepository niceToHaveRepository)
    {
        _logger = logger;
        _languageRepository = languageRepository;
        _mustHavesRepository = mustHavesRepository;
        _niceToHaveRepository = niceToHaveRepository;
    }
    
    [HttpGet]
    public async Task<ActionResult<LanguageModel>> GetAllLanguages()
    {
        var respond =new {res=_languageRepository.GetAllLanguages()};
        
        return Ok(respond);
    }
    
    [HttpPost]
    public async Task<ActionResult<Company>> AddLanguage(LanguageModel language)
    {
        try
        {
            if (language == null)
            {
                return BadRequest($"Please add a valid language");
            }

            _languageRepository.Add(language);
            var response = new { res = language };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occured");
        }
    }
    
    [HttpGet]
    public async Task<ActionResult<LanguageModel>> GetAllMustHaves()
    {
        var respond =new {res=_mustHavesRepository.GetAllMustHaves()};
        
        return Ok(respond);
    }
    [HttpPost]
    public async Task<ActionResult<Company>> AddMustHave(MustHaveModel mustHave)
    {
        try
        {
            if (mustHave == null)
            {
                return BadRequest($"Please add a valid data");
            }

            _mustHavesRepository.Add(mustHave);
            var response = new { res = mustHave };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occured");
        }
    }
    
    [HttpGet]
    public async Task<ActionResult<LanguageModel>> GetAllNiceToHaves()
    {
        var respond =new {res=_niceToHaveRepository.GetAllNiceToHaves()};
        
        return Ok(respond);
    }
    [HttpPost]
    public async Task<ActionResult<Company>> AddNiceToHave(NiceToHaveModel niceToHave)
    {
        try
        {
            if (niceToHave == null)
            {
                return BadRequest($"Please add a valid data");
            }

            _niceToHaveRepository.Add(niceToHave);
            var response = new { res = niceToHave };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occured");
        }
    }
}