using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Services.Repository;

public class CompanyRepository : ICompanyRepository
{
    public IEnumerable<Company> GetAll()
    {
        using var dbContext = new JobScribeContext();
        return dbContext.Companies.ToList();
    }

    public Company? GetByName(string name)
    {
        using var dbContext = new JobScribeContext();
        return dbContext.Companies.SingleOrDefault(c => c.Name == name);
    }

    public void Add(Company company)
    {
        using var dbContext = new JobScribeContext();
        dbContext.Add(company);
        dbContext.SaveChanges();
    }

    public void Delete(Company company)
    {
        using var dbContext = new JobScribeContext();
        dbContext.Remove(company);
        dbContext.SaveChanges();
    }
}