import { useState, useEffect } from "react";
import Navbar from "./Navbar";

function Home({isLoggedIn, setIsLoggedIn}) {
  const [companyData, setCompanyData] = useState("");

  useEffect(() =>{
    getData();
  }, []);

  function getData() {
    fetch("api/Company/GetAllCompanies")
      .then((response) => {
        if (!response.ok) {
          throw new Error(
            `Network response was not ok: ${response.statusText}`
          );
        }
        return response.json();
      })
      .then((data) => {
        const companies = data.res?.result || [];
        setCompanyData(companies);
      })
      .catch((error) => console.error("Error:", error));
  }

  return (
    <>
      <header>
        <Navbar isLoggedIn={isLoggedIn} setIsLoggedIn={setIsLoggedIn}/>
      </header>
      <h1>Welcome to JobScribe basic frontend!</h1>
      <div className="card">
        {Array.isArray(companyData) && companyData.length > 0 ? (
          <table>
            <thead>
              <tr>
                <th>Name</th>
                <th>Location</th>
                <th>Industry</th>
                <th>Founded</th>
              </tr>
            </thead>
            <tbody>
              {companyData.map((company, index) => (
                <tr key={index}>
                  <td>{company.name}</td>
                  <td>{company.location}</td>
                  <td>{company.industry}</td>
                  <td>{company.founded}</td>
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

export default Home;
