namespace JobScribe_stranger_strings.Model;

public class JobOffer
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string Name { get; set; }
    public DateTime Published { get; set; }
    public string Location { get; set; }
    public string Level { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public int ApplicantId { get; set; }
    public bool IsActive { get; set; }
    public List<MustHaveModel> MustHave { get; set; }
    public List<NiceToHaveModel> NiceToHave { get; set; }
}