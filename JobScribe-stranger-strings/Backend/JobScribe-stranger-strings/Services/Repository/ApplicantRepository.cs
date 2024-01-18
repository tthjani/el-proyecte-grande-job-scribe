using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Services.Repository;

public class ApplicantRepository : IApplicantRepository
{
    private readonly JobScribeContext _context;

    public ApplicantRepository(JobScribeContext context)
    {
        _context = context;
    }

    public IEnumerable<Applicant> GetAllApplicants()
    {
        return _context.Applicants.ToList();
    }

    public Applicant? GetApplicantById(int applicantID)
    {
        return _context.Applicants.SingleOrDefault(a=>a.Id == applicantID);
    }

    public void Add(Applicant applicant)
    {
        _context.Add(applicant);
        _context.SaveChanges();
    }

    public void Delete(Applicant applicant)
    {
        _context.Remove(applicant);
        _context.SaveChanges();
    }
}