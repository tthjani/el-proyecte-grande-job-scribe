using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobScribe_stranger_strings.Services.Repository;

public class ApplicantRepository : IApplicantRepository
{
    private readonly JobScribeContext _context;

    public ApplicantRepository(JobScribeContext context)
    {
        _context = context;
    }

    public Task<List<Applicant>> GetAllApplicants()
    {
        return _context.Applicants.ToListAsync();
    }

    public Task<Applicant?> GetApplicantById(int applicantID)
    {
        return _context.Applicants.SingleOrDefaultAsync(a=>a.Id == applicantID);
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
    
    public async Task<Applicant> Update(int id,ApplicantUpdate updatedApplicant)
    {
        var applicantToUpdate =   _context.Applicants.FirstOrDefault(c=>c.Id== id);

        applicantToUpdate.Name = updatedApplicant.Name;
        applicantToUpdate.Email = updatedApplicant.Email;
        applicantToUpdate.Location = updatedApplicant.Location;
        applicantToUpdate.TelephoneNumber = updatedApplicant.TelephoneNumber;
        
        await _context.SaveChangesAsync();

        return applicantToUpdate;
    }
    
    
}