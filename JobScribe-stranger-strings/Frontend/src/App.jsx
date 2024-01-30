import { Route, Routes } from "react-router-dom";
import "./App.css";
import Home from "./Components/Home";
import CompanyRegistration from "./Components/CompanyReg";
import Registration from "./Components/Registration";
import UserLogin from "./Components/UserLogin";


function App() {
  

  return (
    <>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/userregistration" element={<Registration />} />
        <Route path="/companyregistration" element={<CompanyRegistration />} />
        <Route path="/userlogin" element={<UserLogin />} />
      </Routes>
    </>
  );
}

export default App;
