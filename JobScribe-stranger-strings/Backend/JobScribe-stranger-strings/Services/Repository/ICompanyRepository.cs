using JobScribe_stranger_strings.Model;

namespace JobScribe_stranger_strings.Services.Repository;

public interface ICompanyRepository
{
    Task<List<Company>> GetAll();
    Task<Company?> GetByName(string name);
    
    Task<Company?> GetById(int id);

    void Add(Company company);
    void Delete(Company company);

    Task<Company> Update(int id,CompanyUpdate company);
}