namespace JobScribe_stranger_strings.Model;

public class JobOffer
{
    public int Id { get; set; }
    public Company Company { get; set; }
    public string Name { get; set; }
    public DateTime Published { get; set; }
    public string Location { get; set; }
    public string Level { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public IList<string> MustHave { get; set; }
    public IList<string> NiceToHave { get; set; }
    public IList<Applicant>? Applicants { get; set; }
    public bool IsActive { get; set; }
}