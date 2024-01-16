using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Data;

public class ApplicantContext : DbContext
{
    public ApplicantContext(DbContextOptions<ApplicantContext> options) : base(options)
    {
    }

    public DbSet<Applicant> Applicants { get; set; }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Applicant>()
            .HasIndex(c => c.Name);
    }
}