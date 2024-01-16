namespace JobScribe_stranger_strings.Model;

public class CVModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateOnly BirthDate { get; set; }
    public string Email { get; set; }
    public string TelephoneNumber { get; set; }
    public string Location { get; set; }
    public string Level { get; set; }
    public string Category { get; set; }
    public string Education { get; set; }
    public string Description { get; set; }
    public ISet<string>? Experience { get; set; }
    public ISet<string> Languages { get; set; }
    public ISet<string> Skills { get; set; }
    public ISet<string>?  AdditionalSkills { get; set; }
    public bool IsActive { get; set; }
}