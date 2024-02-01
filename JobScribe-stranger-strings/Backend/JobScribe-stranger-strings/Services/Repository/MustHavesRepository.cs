using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Services.Repository;

public class MustHavesRepository : IMustHavesRepository
{
    private readonly JobScribeContext _context;

    public MustHavesRepository(JobScribeContext context)
    {
        _context = context;
    }
    
    public void Add(MustHaveModel mustHave)
    {
        _context.Add(mustHave);
        _context.SaveChanges();
    }

    public void Delete(MustHaveModel mustHave)
    {
        _context.Remove(mustHave);
        _context.SaveChanges();
    }

    public Task<List<MustHaveModel>> GetAllMustHaves()
    {
        return _context.MustHaves.ToListAsync();
    }
}