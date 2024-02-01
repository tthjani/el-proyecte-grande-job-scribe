using JobScribe_stranger_strings.Model;

namespace JobScribe_stranger_strings.Services.Repository;

public interface INiceToHaveRepository
{
    public void Add(NiceToHaveModel niceToHave);
    
    public void Delete(NiceToHaveModel niceToHave);

    public Task<List<NiceToHaveModel>> GetAllNiceToHaves();
}