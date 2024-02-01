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


    public Task<List<Company>> GetAll()
    {
       return _context.Companies.Include(j => j.JobOffers).ToListAsync();
    }

    public Task<Company?> GetByName(string name)
    {
        return _context.Companies.Include(j=>j.JobOffers).SingleOrDefaultAsync(c => c.Name == name);
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