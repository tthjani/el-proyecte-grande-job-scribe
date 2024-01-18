using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Services.Repository;

public class CompanyRepository : ICompanyRepository
{
    private readonly JobScribeContext _context;

    public CompanyRepository(JobScribeContext context)
    {
        _context = context;
    }


    public IEnumerable<Company> GetAll()
    {
       return _context.Companies.Include(j => j.JobOffers).ToList();
    }

    public Company? GetByName(string name)
    {
        return _context.Companies.Include(j=>j.JobOffers).SingleOrDefault(c => c.Name == name);
    }

    public void Add(Company company)
    {
        
        _context.Add(company);
        _context.SaveChanges();
    }

    public void Delete(Company company)
    {
        _context.Remove(company);
        _context.SaveChanges();
    }
}