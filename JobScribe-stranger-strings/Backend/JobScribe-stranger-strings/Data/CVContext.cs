using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Data;

public class CVContext : DbContext
{
    public CVContext(DbContextOptions<CVContext> options) : base(options)
    {
    }

    public DbSet<CVModel> CvModels { get; set; }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<CVModel>()
            .HasIndex(c => c.Name);
    }
}