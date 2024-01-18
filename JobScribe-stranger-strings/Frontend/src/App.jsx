import { useState } from "react";
import "./App.css";
import Navbar from "./Components/Navbar.jsx";

function App() {
  const [companyData, setCompanyData] = useState("");

  function getData() {
    fetch("http://localhost:5225/api/Company/GetAllCompanies")
      .then((response) => response.json())
      .then((data) => setCompanyData(data.res))
      .catch((error) => console.error(error));
  }



  return (
    <>
      <header>
        <Navbar />
      </header>
      <h1>Welcome to JobScribe basic frontend!</h1>
      <div className="card">
        <button onClick={() => getData()}></button>
        {Array.isArray(companyData) && companyData.length > 0 ? (
          <table>
            <thead>
              <tr>
                <th>Name</th>
                <th>Location</th>
                <th>Industry</th>
                <th>Founded</th>
                <th>Description</th>
              </tr>
            </thead>
            <tbody>
              {companyData.map((company) => (
                <tr key={company.id}>
                  <td>{company.name}</td>
                  <td>{company.location}</td>
                  <td>{company.industry}</td>
                  <td>{company.founded}</td>
                  <td>{company.description}</td>
                </tr>
              ))}
            </tbody>
          </table>
        ) : (
          <p>No companies available.</p>
        )}
      </div>
      <p className="read-the-docs">
        The site is under development! Check back later!
      </p>
    </>
  );
}

export default App;
