using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Data;

public class JobScribeContext : DbContext
{
    public JobScribeContext(DbContextOptions<JobScribeContext> options) : base(options)
    {
    }

    public DbSet<Applicant> Applicants { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<CVModel> CvModels { get; set; }
    public DbSet<JobOffer> JobOffers { get; set; }
    public DbSet<ExperienceModel> Experiences { get; set; }
    public DbSet<LanguageModel> Languages { get; set; }
    public DbSet<MustHaveModel> MustHaves { get; set; }
    public DbSet<NiceToHaveModel> NiceToHaves { get; set; }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
       /* builder.Entity<Company>()
            .HasIndex(c => c.Id)
            .IsUnique();
        
        builder.Entity<Company>()
            .HasMany(c => c.JobOffers)
            .WithOne(j => j.Company)
            .HasForeignKey(j => j.CompanyId);
        
        builder.Entity<JobOffer>()
            .HasIndex(c => c.Id)
            .IsUnique();

        builder.Entity<JobOffer>()
            .HasMany(j => j.MustHave)
            .WithOne(m => m.JobOffer)
            .HasForeignKey(m => m.JobOfferId);
        
        builder.Entity<JobOffer>()
            .HasMany(j => j.NiceToHave)
            .WithOne(m => m.JobOffer)
            .HasForeignKey(m => m.JobOfferId);
        
        builder.Entity<Applicant>()
            .HasMany(j => j.Application)
            .WithOne(j => j.Applicant)
            .HasForeignKey(j => j.ApplicantId);

        builder.Entity<Applicant>()
            .HasIndex(a => a.Id)
            .IsUnique();

        builder.Entity<CVModel>()
            .HasMany(c => c.Languages)
            .WithOne(l => l.CVModel)
            .HasForeignKey(l => l.CVModelId);
        
        builder.Entity<CVModel>()
            .HasMany(c => c.Experience)
            .WithOne(e => e.CVModel)
            .HasForeignKey(e => e.CVModelId);
        
        builder.Entity<CVModel>()
            .HasMany(c => c.MustHave)
            .WithOne(s => s.CVModel)
            .HasForeignKey(s => s.CVModelId);
        
        builder.Entity<CVModel>()
            .HasMany(c => c.NiceToHave)
            .WithOne(a => a.CVModel)
            .HasForeignKey(a => a.CVModelId);*/

        builder.Entity<ExperienceModel>()
            .HasData(
                new ExperienceModel { /*CVModelId = 1,*/ Id = 1, Item = "Voltam már balatonon" }
            );

        builder.Entity<LanguageModel>()
            .HasData(
                new LanguageModel { /*CVModelId = 1,*/ Id = 1, Item = "English" }
            );

        builder.Entity<MustHaveModel>()
            .HasData(
                new MustHaveModel { /*CVModelId = 1, JobOfferId = 1,*/ Id = 1, Item = "Javascript" }
            );

        builder.Entity<NiceToHaveModel>()
            .HasData(
                new NiceToHaveModel { /*CVModelId = 1, JobOfferId = 1,*/ Id = 2, Item = "React" }
            );
        
        
        builder.Entity<Company>()
            .HasData(
                new Company
                {
                    Description = "In 2014, we started Codecool with the vision that quality coding education can change lives and workplaces for the better.",
                    Founded = 2014,
                    Id = 3,
                    Industry = "Education",
                    Location = "Budapest",
                    Name = "CodeCool"
                }
            );
        
        builder.Entity<Company>()
            .HasData(
                new Company
                {
                    Description = "Polygence is a team of academics and educators united in our passion to make research more widely accessible to all interested students.",
                    Founded = 2019,
                    Id = 4,
                    Industry = "Education",
                    Location = "Budapest",
                    Name = "Polygence"
                }
            );
        
        builder.Entity<Company>()
            .HasData(
                new Company
                {
                    Description = "Ulyssys is one of the leading software development companies in Hungary with a team of 300 professionals. It has a 30-year successful track record in custom software development.",
                    Founded = 1991,
                    Id = 5,
                    Industry = "IT Services and IT Consulting",
                    Location = "Budapest",
                    Name = "Ulyssys Kft."
                }
            );
        
        builder.Entity<Company>()
            .HasData(
                new Company
                {
                    Description = "OPSWAT protects critical infrastructure (CIP). Our goal is to eliminate malware and zero-day attacks.",
                    Founded = 2002,
                    Id = 6,
                    Industry = "Information technology & services",
                    Location = "Veszprém",
                    Name = "OPSWAT"
                }
            );
        builder.Entity<Company>()
            .HasData(
                new Company
                {
                    Description = "Born in Stuttgart, made for the world. At Flexopus, we create New Work together with our customers. As a leading workplace management B2B software, we enable the flexible and digital management of office resources in one tool.",
                    Founded = 2020,
                    Id = 7,
                    Industry = "Web tools",
                    Location = "Budapest",
                    Name = "Flexopus"
                }
            );
        
        builder.Entity<JobOffer>()
            .HasData(
                new JobOffer
                {
                    ApplicantId = 1,
                    Category = "DevOps",
                    Id = 1,
                    Description = "Valami leírás kell",
                    Location = "Nyíregyh",
                    CompanyId = 4,
                    Name = "DevOps Engineer",
                    Published = new DateTime(2021, 01, 01), IsActive = true, Level = "junior"
                }
            );

        builder.Entity<Applicant>()
            .HasData(
                new Applicant
                {
                    Email = "valaki@valaki.vl",
                    Id = 1,
                    Location = "Deb",
                    TelephoneNumber = "785656456456",
                    Name = "Pista",
                    Gender = "Male",
                    UserName = "pistavok12"
                }
            );
        builder.Entity<CVModel>()
            .HasData(
                new CVModel
                {
                    BirthDate = new DateTime(1932, 04, 12),
                    Description = "Én megyek oda",
                    Category = "C#",
                    Id = 1,
                    Location = "Mucsaröcsöge",
                    TelephoneNumber = "8768716273462",
                    Education = "diploma",
                    Email = "valaki@valaki.vl",
                    IsActive = true,
                    Level = "Senior",
                    Name = "Pista"
                }
            );
    }
}