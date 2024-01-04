import { useState } from "react";
import "./App.css";

function App() {
  const [test, setTest] = useState("");

  function getData() {
    fetch("http://localhost:5225/api/JobScribe")
      .then((response) => response.json())
      .then((data) => setTest(data.res))
      .catch((error) => console.error(error));
  }

  return (
    <>
      <h1>Welcome to JobScribe basic frontend!</h1>
      <div className="card">
        <button onClick={() => getData()}>Click to test connection</button>
        <p>{test}</p>
      </div>
      <p className="read-the-docs">
        The page is under development! Come back later!!
      </p>
    </>
  );
}

export default App;
