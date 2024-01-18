import {useState, useEffect} from "react";


const Registration = () => {
    const [Username, setUsername] = useState('');
    const [Password, setPassword] = useState('');
    const [Email, setEmail] = useState('');
    const [Role, setRole] = useState('');



    const handleUsernameChange = (e) => {
        setUsername(e.target.value);
    };

    const handlePasswordChange = (e) => {
        setPassword(e.target.value);
    };

    const handleEmailChange = (e) => {
        setEmail(e.target.value);
    };

    const handleRoleChange = (e) => {
        setRole(e.target.value);
    };

    const handleSubmit = (e) => {
        e.preventDefault();


        const data = { Email, Username, Password, Role };
    fetch('http://localhost:5225/Register',{
      method: 'POST',
      headers: {'Content-Type': 'application/json'},
      body: JSON.stringify(data)
    })
        .then((res) => {
            console.log(data)
            console.log("Status: " + res.status);
            if (res.status === 201) {
               console.log("User registrated sucessfully") 
            } else {
                console.log("Registration failed")
            }
        })
        .catch((error) => {
            console.error("Connection error:", error);
        });
    };


    return(
        <div>
            <form onSubmit={handleSubmit}>
                <h3>Registration</h3>
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
                name="password"
                placeholder="Enter password"
                value={Password}
                onChange={handlePasswordChange}
                id="password"
                />
                <label>Role</label>
                <input
                name="role"
                placeholder="Enter role"
                value={Role}
                onChange={handleRoleChange}
                id="role"
                />
                    <input type="submit" className="reg-button" value="Submit"/>
            </form>
        </div>
    );
    };

    export default Registration;

    
