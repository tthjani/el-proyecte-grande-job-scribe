using JobScribe_stranger_strings.Contracts;
using JobScribe_stranger_strings.Services.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace JobScribe_stranger_strings.Controllers;

[ApiController]
[Route("/api/[controller]/[action]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authenticationService;

    public AuthController(IAuthService authenticationService)
    {
        _authenticationService = authenticationService;
    }
    
    [HttpPost]
    public async Task<ActionResult<RegistrationResponse>> UserRegister(RegistrationRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _authenticationService.RegisterAsync(request.Email, request.Username, request.Password, "User");

        if (!result.Success)
        {
            AddErrors(result);
            return BadRequest(ModelState);
        }

        return CreatedAtAction(nameof(UserRegister), new RegistrationResponse(result.Email, result.UserName));
    }
    
    [HttpPost]
    public async Task<ActionResult<RegistrationResponse>> CompanyRegister(RegistrationRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _authenticationService.RegisterAsync(request.Email, request.Username, request.Password, "Company");

        if (!result.Success)
        {
            AddErrors(result);
            return BadRequest(ModelState);
        }

        return CreatedAtAction(nameof(CompanyRegister), new RegistrationResponse(result.Email, result.UserName));
    }

    private void AddErrors(AuthResult result)
    {
        foreach (var error in result.ErrorMessages)
        {
            ModelState.AddModelError(error.Key, error.Value);
        }
    }
    
    [HttpPost]
    public async Task<ActionResult<AuthResponse>> UserAuthenticate(AuthRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _authenticationService.LoginAsync(request.Email, request.Password);

        if (!result.Success)
        {
            AddErrors(result);
            return BadRequest(ModelState);
        }
        setTokenCookie(result.Token, "access_token");
        
        return Ok(new AuthResponse(result.Email, result.UserName, result.Token));
    }
    
    [HttpPost]
    public async Task<ActionResult<AuthResponse>> CompanyAuthenticate(AuthRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _authenticationService.LoginAsync(request.Email, request.Password);

        if (!result.Success)
        {
            AddErrors(result);
            return BadRequest(ModelState);
        }
        setTokenCookie(result.Token, "access_token");
        
        return Ok(new AuthResponse(result.Email, result.UserName, result.Token));
    }
    
    //Logouthoz kell majd a return elé Response.Cookies.Delete("access_token");
    
    private void setTokenCookie(string token, string tokenName)
    {

        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Expires = DateTime.UtcNow.AddMinutes(30)
        };
        Response.Cookies.Append(tokenName, token, cookieOptions);
    }
}