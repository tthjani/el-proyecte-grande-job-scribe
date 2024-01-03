using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Data;

public class JobScribeContext : DbContext
{
    public DbSet<Company> Companies { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1434;Database=JobScribe;User Id=sa;Password=yourStrong(!)Password;Encrypt=false;");
    }
}