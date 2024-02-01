using JobScribe_stranger_strings.Model;

namespace JobScribe_stranger_strings.Services.Repository;

public interface IMustHavesRepository
{
    public void Add(MustHaveModel mustHave);
    
    public void Delete(MustHaveModel mustHaveModel);

    public Task<List<MustHaveModel>> GetAllMustHaves();
}