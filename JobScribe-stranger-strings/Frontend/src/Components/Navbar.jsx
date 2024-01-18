import { useState } from "react";

function Navbar() {
  const [registerDropdown, setRegisterDropdown] = useState(false);
  const [loginDropdown, setLoginDropdown] = useState(false);

  const toggleRegisterDropdown = () => {
    setRegisterDropdown(!registerDropdown);
    setLoginDropdown(false);
  };

  const toggleLoginDropdown = () => {
    setLoginDropdown(!loginDropdown);
    setRegisterDropdown(false);
  };

  const handleJobhunterRegister = () => {
    console.log("Register as Jobhunter clicked");
  };

  const handleCompanyRegister = () => {
    console.log("Register as Company clicked");
  };

  const handleJobhunterLogin = () => {
    console.log("Login as Jobhunter clicked");
  };

  const handleCompanyLogin = () => {
    console.log("Login as Company clicked");
  };

  return (
    <div>
      <nav className="navbar">
        <div className="dropdownReg">
          <button className="regButton" onClick={toggleRegisterDropdown}>
            Register
          </button>
          {registerDropdown && (
            <div className="regDrop">
              <button onClick={handleJobhunterRegister}>
                Register as Jobhunter
              </button>
              <button onClick={handleCompanyRegister}>
                Register as Company
              </button>
            </div>
          )}
        </div>
        <button className="jobButton">Job Offers</button>
        <div className="dropdownLog">
          <button className="loginButton" onClick={toggleLoginDropdown}>
            Login
          </button>
          {loginDropdown && (
            <div className="loginDrop">
              <button onClick={handleJobhunterLogin}>Login as Jobhunter</button>
              <button onClick={handleCompanyLogin}>Login as Company</button>
            </div>
          )}
        </div>
      </nav>
    </div>
  );
}

export default Navbar;
