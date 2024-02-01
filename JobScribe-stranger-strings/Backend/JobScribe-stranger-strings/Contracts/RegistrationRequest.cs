using System.ComponentModel.DataAnnotations;

namespace JobScribe_stranger_strings.Contracts;

public record RegistrationRequest(
    [Required]string Email, 
    [Required]string Username, 
    [Required]string Password
    );