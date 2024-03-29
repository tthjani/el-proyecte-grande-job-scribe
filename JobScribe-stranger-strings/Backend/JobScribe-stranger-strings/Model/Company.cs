namespace JobScribe_stranger_strings.Model;

public class Company
{
    public int Id { get; init; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string Industry { get; set; }
    public int Founded { get; set; }
    public string Description { get; set; }
    public List<JobOffer>? JobOffers { get; set; }
}