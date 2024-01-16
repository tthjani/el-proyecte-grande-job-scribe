using JobScribe_stranger_strings.Model;

namespace JobScribe_stranger_strings.Services.Repository;

public interface ICompanyRepository
{
    IEnumerable<Company> GetAll();
    Company? GetByName(string name);

    void Add(Company company);
    void Delete(Company company); 
}