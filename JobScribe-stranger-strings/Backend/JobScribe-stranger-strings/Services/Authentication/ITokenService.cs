using Microsoft.AspNetCore.Identity;

namespace JobScribe_stranger_strings.Services.Authentication;

public interface ITokenService
{
    public string CreateToken(IdentityUser user, string role);
}