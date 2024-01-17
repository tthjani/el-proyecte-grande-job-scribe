namespace JobScribe_stranger_strings.Model;

public class Company
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Location { get; init; }
    public string Industry { get; init; }
    public int Founded { get; init; }
    public string Description { get; init; }
    public List<JobOffer>? JobOffers { get; set; }
}