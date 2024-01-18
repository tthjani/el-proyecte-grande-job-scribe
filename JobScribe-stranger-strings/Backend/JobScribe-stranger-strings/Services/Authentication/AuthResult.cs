namespace JobScribe_stranger_strings.Services.Authentication;

public record AuthResult(
    bool Success,
    string Email,
    string UserName,
    string Token)
{
    public readonly Dictionary<string, string> ErrorMessages = new();
}