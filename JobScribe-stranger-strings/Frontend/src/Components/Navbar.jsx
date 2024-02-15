import React, { useState } from "react";
import { Link, useNavigate } from "react-router-dom";

function Navbar({isLoggedIn, setIsLoggedIn}) {
  const [registerDropdown, setRegisterDropdown] = useState(false);
  const [loginDropdown, setLoginDropdown] = useState(false);
  const navigate = useNavigate();

  const toggleRegisterDropdown = () => {
    setRegisterDropdown(!registerDropdown);
    setLoginDropdown(false);
  };

  const toggleLoginDropdown = () => {
    setLoginDropdown(!loginDropdown);
    setRegisterDropdown(false);
  };

  const handleLogout = async () => {
    try {
      setIsLoggedIn(false); 
      navigate("/logout");
    } catch (error) {
      console.error("Something went wrong with logout...", error);
    }
  };

  return (
    <div>
      <nav className="navbar">
        <div className="dropdownReg">
          {isLoggedIn ?  (
            <>
            <button className="regButton">
              <Link to="/profile">Profile</Link>
            </button>
             <button className="cvButton">
             <Link to="/addCV">Add CV</Link>
           </button>
           </>
          ) : (
            <button className="regButton" onClick={toggleRegisterDropdown}>
              Register
            </button>
          )}
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
          {isLoggedIn ? (
            <button className="loginButton" onClick={handleLogout}>
              Logout
            </button>
          ) : (
            <button className="loginButton" onClick={toggleLoginDropdown}>
              Login
            </button>
          )}
          {loginDropdown && (
            <div className="loginDrop">
              <button>
                <Link to="/userlogin">Login as Jobhunter</Link>
              </button>
              <button>
                <Link to="/companylogin">Login as Company</Link>
              </button>
            </div>
          )}
        </div>
      </nav>
    </div>
  );
}

export default Navbar;
