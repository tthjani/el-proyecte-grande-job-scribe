using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Services.Repository;

public class LanguageRepository : ILanguageRepository
{
    private readonly JobScribeContext _context;

    public LanguageRepository(JobScribeContext context)
    {
        _context = context;
    }
    
    public void Add(LanguageModel language)
    {
        _context.Add(language);
        _context.SaveChanges();
    }

    public void Delete(LanguageModel language)
    {
        _context.Remove(language);
        _context.SaveChanges();
    }

    public Task<List<LanguageModel>> GetAllLanguages()
    {
        return _context.Languages.ToListAsync();
    }
}