import { Link } from "react-router-dom";
import "./CVTable.css";

const CVTable = ({ applicants, onDelete }) => (


    <div className="CVTable">
      <table>
        <thead>
          <tr>
            <th>Name</th>
            <th>Birthdate</th>
            <th>Email</th>
            <th>Telephone number</th>
            <th />
          </tr>
        </thead>
        <tbody>
          {applicants.map((applicant) => (
                <tr key={applicant.id}>
                <td>{applicant.name}</td>
                <td>{applicant.birthDate}</td>
                <td>{applicant.email}</td>
                <td>{applicant.telephoneNumber}</td>
                <td>
                  <Link to={`/update/${applicant.id}`}>
                    <button type="button">Update</button>
                  </Link>
                  <button type="button" onClick={() => onDelete(applicant.id)}>
                    Delete
                  </button>
                </td>
              </tr>
          ))}
        </tbody>
      </table>
    </div>
  );

export default CVTable;
