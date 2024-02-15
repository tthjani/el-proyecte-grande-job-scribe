using JobScribe_stranger_strings.Model;

namespace JobScribe_stranger_strings.Services.Repository;

public interface IApplicantRepository
{
   Task<List<Applicant>> GetAllApplicants();
   Task<Applicant?> GetApplicantById(int applicantID);

   void Add(Applicant applicant);
   void Delete(Applicant applicant); 
   
   Task<Applicant> Update(int id,ApplicantUpdate applicant);
  }