using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Data;

public class JobOfferContext :DbContext
{
    public JobOfferContext(DbContextOptions<JobOfferContext> options) : base(options)
    {
    }

    public DbSet<JobOffer> JobOffers { get; set; }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<JobOffer>()
            .HasIndex(c => c.Name)
            .IsUnique();
    }
}