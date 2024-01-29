﻿using JobScribe_stranger_strings.Contracts;
using JobScribe_stranger_strings.Services.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace JobScribe_stranger_strings.Controllers;

public class AuthController : ControllerBase
{
    private readonly IAuthService _authenticationService;

    public AuthController(IAuthService authenticationService)
    {
        _authenticationService = authenticationService;
    }
    
    [HttpPost("UserRegister")]
    public async Task<ActionResult<RegistrationResponse>> UserRegister([FromBody]RegistrationRequest request)
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
    
    [HttpPost("CompanyRegister")]
    public async Task<ActionResult<RegistrationResponse>> CopmanyRegister([FromBody]RegistrationRequest request)
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

        return CreatedAtAction(nameof(CopmanyRegister), new RegistrationResponse(result.Email, result.UserName));
    }

    private void AddErrors(AuthResult result)
    {
        foreach (var error in result.ErrorMessages)
        {
            ModelState.AddModelError(error.Key, error.Value);
        }
    }
    
    [HttpPost("Login")]
    public async Task<ActionResult<AuthResponse>> Authenticate([FromBody] AuthRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _authenticationService.LoginAsync(request.UserName, request.Password);

        if (!result.Success)
        {
            AddErrors(result);
            return BadRequest(ModelState);
        }

        return Ok(new AuthResponse(result.Email, result.UserName, result.Token));
    }
}