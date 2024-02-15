import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import React, { useEffect, useState } from "react";
import "./App.css";
import CVCreator from "./CVCreator";
import Home from "./Components/Home";
import CompanyRegistration from "./Components/Authentication/CompanyReg";
import Registration from "./Components/Authentication/UserRegistration";
import UserLogin from "./Components/Authentication/UserLogin";
import CompanyLogin from "./Components/Authentication/CompanyLogin";
import Logout from "./Components/Authentication/Logout";


function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(null);

  useEffect(()=>{
    if(isLoggedIn){
      localStorage.setItem("login", isLoggedIn)
    } else if(isLoggedIn === null){
      setIsLoggedIn(localStorage.getItem("login"))
    }else{
      localStorage.removeItem("login")
    }
  }, [isLoggedIn])

  return (
    <>
      <Router>
        <Routes>
          <Route
            path="/"
            element={
              <Home isLoggedIn={isLoggedIn} setIsLoggedIn={setIsLoggedIn} />
            }
          />
          <Route path="/userregistration" element={<Registration />} />
          <Route
            path="/companyregistration"
            element={<CompanyRegistration />}
          />
          <Route
            path="/addCV"
            element={<CVCreator />}
          />
          <Route
            path="/userlogin"
            element={<UserLogin setIsLoggedIn={setIsLoggedIn} />}
          />
          <Route path="/companylogin" element={<CompanyLogin />} />
          <Route path="/logout" element={<Logout />} />
        </Routes>
      </Router>
    </>
  );
}

export default App;
