import { useState } from "react";
import { Link } from "react-router-dom";

const CompanyLogin = () => {
  const [Password, setPassword] = useState("");
  const [Email, setEmail] = useState("");
  const [succesfullLogin, setSuccesfullLogin] = useState(false);

  const handlePasswordChange = (e) => {
    setPassword(e.target.value);
  };

  const handleEmailChange = (e) => {
    setEmail(e.target.value);
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    const data = { Email, Password };
    fetch("/api/Auth/CompanyAuthenticate", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(data),
    })
      .then((res) => {
        console.log("Status: " + res.status);
        if (res.status === 200) {
          setSuccesfullLogin(true);
          console.log("Login sucessfully");
          return res.json();
        } else {
          console.log("Login failed");
        }
      })
      .catch((error) => {
        console.error("Connection error:", error);
      });
  };

  return (
    <div>
      {succesfullLogin ? (
        <h1> Login succesfull! </h1>
      ) : (
        <form onSubmit={handleSubmit}>
          <h3>Login as Company</h3>
          <label>E-mail</label>
          <input
            name="email"
            placeholder="Enter email"
            value={Email}
            onChange={handleEmailChange}
            id="email"
          />
          <label>Password</label>
          <input
            type="password"
            name="password"
            placeholder="Enter password"
            value={Password}
            onChange={handlePasswordChange}
            id="password"
          />
          <button type="submit" className="reg-button" value="Submit">
            Submit
          </button>
        </form>
      )}
      <button>
        <Link to="/">Home</Link>
      </button>
    </div>
  );
};

export default CompanyLogin;
