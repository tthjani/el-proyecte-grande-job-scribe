using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
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
    
    public Task<Company?> GetById(int id)
    {
        return _context.Companies.Include(j=>j.JobOffers).SingleOrDefaultAsync(c => c.Id == id);
    }

    public void Add(Company company)
    {
        
        _context.Add(company);
        _context.SaveChangesAsync();
    }

    public void Delete(Company company)
    {
        _context.Remove(company);
        _context.SaveChangesAsync();
    }

    public async Task<Company> Update(int id,CompanyUpdate updatedCompany)
    {
        var companyToUpdate =   _context.Companies.FirstOrDefault(c=>c.Id== id);
        
        companyToUpdate.Name = updatedCompany.Name;
        companyToUpdate.Location = updatedCompany.Location;
        companyToUpdate.Founded = updatedCompany.Founded;
        companyToUpdate.Industry = updatedCompany.Industry;
        companyToUpdate.Description = updatedCompany.Description;
        await _context.SaveChangesAsync();

        return companyToUpdate;
    }
}