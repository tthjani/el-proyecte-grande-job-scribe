using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Services.Repository;

public class CompanyRepository : ICompanyRepository
{
    private readonly CompanyContext _companyContext;

    public CompanyRepository(CompanyContext companyContext)
    {
        _companyContext = companyContext;
    }


    public IEnumerable<Company> GetAll()
    {
       return _companyContext.Companies.ToList();
    }

    public Company? GetByName(string name)
    {
        return _companyContext.Companies.SingleOrDefault(c => c.Name == name);
    }

    public void Add(Company company)
    {
        
        _companyContext.Add(company);
        _companyContext.SaveChanges();
    }

    public void Delete(Company company)
    {
        _companyContext.Remove(company);
        _companyContext.SaveChanges();
    }
}