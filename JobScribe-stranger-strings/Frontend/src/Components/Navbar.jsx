import { useState } from "react";
import { Link } from "react-router-dom";

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


  return (
    <div>
      <nav className="navbar">
        <div className="dropdownReg">
          <button className="regButton" onClick={toggleRegisterDropdown}>
            Register
          </button>
          {registerDropdown && (
            <div className="regDrop">
              <button>
                <Link to="/userregistration">Register as Jobhunter</Link>
              </button>
              <button>
                <Link to="/companyregistration">Register as Company</Link>
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
              <button>
                <Link to="/userlogin">Login as Jobhunter</Link>
              </button>
              <button>Login as Company</button>
            </div>
          )}
        </div>
      </nav>
    </div>
  );
}

export default Navbar;