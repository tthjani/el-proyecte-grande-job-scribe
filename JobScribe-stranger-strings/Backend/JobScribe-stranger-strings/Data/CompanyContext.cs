using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Data;

public class CompanyContext : DbContext
{
    public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
    {
    }

    public DbSet<Company> Companies { get; set; }
    
    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(optionsBuilder.Configuration.GetConnectionString("JobScribeConnection"));
    }*/

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Company>()
            .HasIndex(c => c.Name)
            .IsUnique();
    }
}