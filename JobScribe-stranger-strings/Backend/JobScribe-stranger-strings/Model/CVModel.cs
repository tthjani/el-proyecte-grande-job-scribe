namespace JobScribe_stranger_strings.Model;

public class CVModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string Email { get; set; }
    public string TelephoneNumber { get; set; }
    public string Location { get; set; }
    public string Level { get; set; }
    public string Category { get; set; }
    public string Education { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public List<ExperienceModel>? Experience { get; set; }
    public List<LanguageModel> Languages { get; set; }
    public List<MustHaveModel> MustHave { get; set; }
    public List<NiceToHaveModel>?  NiceToHave { get; set; }
}