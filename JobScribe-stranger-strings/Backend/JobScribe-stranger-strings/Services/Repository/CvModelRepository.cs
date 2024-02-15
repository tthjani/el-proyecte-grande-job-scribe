using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Services.Repository;

public class CvModelRepository: ICvModelRepository
{
    private readonly JobScribeContext _context;
    
    public CvModelRepository(JobScribeContext context)
    {
        _context = context;
    }
    public void Add(CVModel cvModel)
    {
        _context.Add(cvModel);
        _context.SaveChanges();
    }
    
}