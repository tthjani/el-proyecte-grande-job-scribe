using JobScribe_stranger_strings.Model;

namespace JobScribe_stranger_strings.Services.Repository;

public interface ILanguageRepository
{
    public void Add(LanguageModel language);
    
    public void Delete(LanguageModel language);

    public Task<List<LanguageModel>> GetAllLanguages();
}