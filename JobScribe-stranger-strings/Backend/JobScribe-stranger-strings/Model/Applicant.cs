namespace JobScribe_stranger_strings.Model;

public class Applicant
{
    public int Id { get; init; }
    public string Name { get; set; }
    public string UserName { get; init; }
    public string Location { get; set; }
    public string? Gender { get; set; }
    public string Email { get; set; }
    public string TelephoneNumber { get; set; }
    public IEnumerable<JobOffer>? Application { get; set; }
}