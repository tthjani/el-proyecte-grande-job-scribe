import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";

const UserLogin = ({ setIsLoggedIn }) => {
  const [Password, setPassword] = useState("");
  const [Email, setEmail] = useState("");
  const [succesfullLogin, setSuccesfullLogin] = useState(false);
  const navigate = useNavigate();

  const handlePasswordChange = (e) => {
    setPassword(e.target.value);
  };

  const handleEmailChange = (e) => {
    setEmail(e.target.value);
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    const data = { Email, Password };
    fetch("/api/Auth/UserAuthenticate", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(data),
    })
      .then((res) => {
        console.log("Status: " + res.status);
        if (res.status === 200) {
          setSuccesfullLogin(true);
          setIsLoggedIn(true);
          setTimeout(() => {
            navigate("/");
          }, 1500);
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
        <>
          <h1>Signing in...</h1>
          <div className="loader"></div>
        </>
      ) : (
        <form onSubmit={handleSubmit}>
          <h3>Login as Jobhunter</h3>
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
    </div>
  );
};

export default UserLogin;
