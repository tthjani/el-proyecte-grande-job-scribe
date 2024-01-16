using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Data;

public class CompanyContext : DbContext
{
    public DbSet<Company> Companies { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1434;Database=JobScribe;User Id=sa;Password=yourStrong(!)Password;Encrypt=false;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Company>()
            .HasIndex(c => c.Name)
            .IsUnique();

       /* builder.Entity<Company>()
            .HasData(

                new Company
                {
                    Id = 1, Name = "Polygence", Location = "Budapest", Industry = "Education", Founded = 2019,
                    Description =
                        "Polygence is a team of academics and educators united in our passion to make research more widely accessible to all interested students. That is why we decided to establish an education company that has the potential to inspire and transform the academic journeys of generations of students to come. This is how Polygence got started - excited to mobilize our academic networks in the academic community, we wanted to give the gift of learning and intellectual inquiry to students from all over the world. "
                },
                new Company
                {
                    Id = 2, Name = "Hearsay", Location = "Budapest", Industry = "Fintech", Founded = 2009,
                    Description =
                        "Founded in 2009, Hearsay Systems is the trusted global leader in digital client engagement for financial services. Our Client Engagement Platform empowers over 225,000 advisors and agents to proactively guide and capture the last mile of digital communications in a compliant manner. The world’s leading financial firms—including BlackRock, Charles Schwab,  and New York Life—rely on Hearsay’s compliance-driven platform to scale their reach, optimize sales engagements, grow their business, and deliver exceptional client service. "
                },
                new Company
                {
                    Id = 3, Name = "Hays Hungary", Location = "Budapest", Industry = "Recruiting", Founded = 2007,
                    Description = "Hays Specialist Recruitment is a leading global professional recruiting group. We are the expert at recruiting qualified, professional and skilled people worldwide, being the market leader in the UK and Asia Pacific and one of the market leaders in Continental Europe and Latin America. We operate across the private and public sectors, dealing in permanent positions, contract roles and temporary assignments. "
                },
                new Company
                {
                    Id = 4, Name = "NIX Tech", Location = "Budapest", Industry = "Outsourcing", Founded = 2022,
                    Description = "NIX is a global supplier of software engineering and IT outsourcing services. NIX teams collaborate with partners from different countries. Our specialists have experience in developing innovative projects from e-commerce to cloud for some of the largest companies in the world, including the Fortune 500. The teams are focused on the stable development of the international IT market, business, and their own professional skills."
                });*/
    }
}