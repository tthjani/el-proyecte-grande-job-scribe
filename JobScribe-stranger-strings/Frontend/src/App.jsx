import { Route, Routes } from "react-router-dom";
import "./App.css";
import Home from "./Components/Home";
import CompanyRegistration from "./Components/CompanyReg";
import Registration from "./Components/Registration";


function App() {
  

  return (
    <>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/userregistration" element={<Registration />} />
        <Route path="/companyregistration" element={<CompanyRegistration />} />
      </Routes>
    </>
  );
}

export default App;
