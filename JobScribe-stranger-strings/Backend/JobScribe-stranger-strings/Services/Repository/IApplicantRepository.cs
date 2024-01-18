using JobScribe_stranger_strings.Model;

namespace JobScribe_stranger_strings.Services.Repository;

public interface IApplicantRepository
{
   IEnumerable<Applicant> GetAllApplicants();
   Applicant GetApplicantById(int applicantID);

   void Add(Applicant applicant);
   void Delete(Applicant applicant); 
  }