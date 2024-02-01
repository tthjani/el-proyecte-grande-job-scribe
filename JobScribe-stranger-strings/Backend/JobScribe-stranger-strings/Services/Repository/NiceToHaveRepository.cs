using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Services.Repository;

public class NiceToHaveRepository : INiceToHaveRepository
{
    private readonly JobScribeContext _context;

    public NiceToHaveRepository(JobScribeContext context)
    {
        _context = context;
    }
    
    public void Add(NiceToHaveModel niceToHave)
    {
        _context.Add(niceToHave);
        _context.SaveChanges();
    }

    public void Delete(NiceToHaveModel niceToHave)
    {
        _context.Remove(niceToHave);
        _context.SaveChanges();
    }

    public Task<List<NiceToHaveModel>> GetAllNiceToHaves()
    {
        return _context.NiceToHaves.ToListAsync();
    }
}