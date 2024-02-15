import { useNavigate } from "react-router-dom";
import CVForm from "./Components/CVForm";


const createApplicant = (applicant) => {
    return fetch("/api/Applicant/AddCVModel", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(applicant),
    }).then((res) => res.json());
  };

  const CVCreator = () => {
    const navigate = useNavigate();
  
    const handleCreateApplicant = (applicant) => {
  
      createApplicant(applicant)
        .then(() => {
          navigate("/");
        })
    };
  
    return (
      <CVForm
        onCancel={() => navigate("/")}
        onSave={handleCreateApplicant}
      />
    );
  };
  
  export default CVCreator;
  