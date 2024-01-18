import { useState } from "react";
import {Outlet, Link} from "react-router-dom";

const Navbar = () => (
<div className="Navbar">
<nav>
  <ul>
    <li>
      <Link to = "/registration">
        <button type="button">Registration</button>
      </Link>
    </li>

  </ul>
</nav>
<Outlet />
</div>
)

/* <div>
      <nav className="navbar">
        <ul>
        <div className="dropdownReg">
          <button className="regButton" onClick={toggleRegisterDropdown}>
            Register
          </button>
          {registerDropdown && (
            <div className="regDrop">
              <li>
                <Link to="/registration">
                  <button type="button">Register as Jobhunter</button>
                </Link>
              </li>
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
        </ul>
      </nav>
    </div>
  ; */




  // const [registerDropdown, setRegisterDropdown] = useState(false);
  // const [loginDropdown, setLoginDropdown] = useState(false);

  // const toggleRegisterDropdown = () => {
  //   setRegisterDropdown(!registerDropdown);
  //   setLoginDropdown(false);
  // };

  // const toggleLoginDropdown = () => {
  //   setLoginDropdown(!loginDropdown);
  //   setRegisterDropdown(false);
  // };

  // const handleJobhunterRegister = () => {
  //   console.log("Register as Jobhunter clicked");
  // };

  // const handleCompanyRegister = () => {
  //   console.log("Register as Company clicked");
  // };

  // const handleJobhunterLogin = () => {
  //   console.log("Login as Jobhunter clicked");
  // };

  // const handleCompanyLogin = () => {
  //   console.log("Login as Company clicked");
  // };

export default Navbar;
