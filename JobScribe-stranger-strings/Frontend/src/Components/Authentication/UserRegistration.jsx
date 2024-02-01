import { useState } from "react";
import { Link } from "react-router-dom";

const UserRegistration = () => {
  const [Username, setUsername] = useState("");
  const [Password, setPassword] = useState("");
  const [Email, setEmail] = useState("");
  const [succesfullRegistration, setSuccesfullRegistration] = useState(false);

  const handleUsernameChange = (e) => {
    setUsername(e.target.value);
  };

  const handlePasswordChange = (e) => {
    setPassword(e.target.value);
  };

  const handleEmailChange = (e) => {
    setEmail(e.target.value);
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    const data = { Email, Username, Password };
    fetch("/api/Auth/UserRegister", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(data),
    })
      .then((res) => {
        console.log("Status: " + res.status);
        if (res.status === 201) {
          setSuccesfullRegistration(true);
          console.log("Registration sucessfully");
        } else {
          console.log("Registration failed");
        }
      })
      .catch((error) => {
        console.error("Connection error:", error);
      });
  };

  return (
    <div>
      {succesfullRegistration ? (
        <h1> Succesfull registration! </h1>
      ) : (
        <form onSubmit={handleSubmit}>
          <h3>Registration as jh</h3>
          <label className="username"> Username</label>
          <input
            name="username"
            placeholder="Enter username"
            value={Username}
            onChange={handleUsernameChange}
            id="username"
          />
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

export default UserRegistration;
