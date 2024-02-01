import React, { useEffect } from "react";
import { useNavigate } from "react-router-dom";

const Logout = () => {

const navigate = useNavigate();

  useEffect(() => {
    const logoutUser = async () => {
      try {
        const response = await fetch("/api/Auth/Logout", {
          method: "POST",
          credentials: "include",
        });

        if (response.ok) {
          console.log("Sucessful logout");
        } else {
          console.error("Logout failed");
        }
        setTimeout(() => {navigate("/")}, 1500);
      } catch (error) {
        console.error("Something wrong with logout...", error);
      }
    };

    logoutUser();
  }, []);

  return (
    <>
      <h1>Signing out...</h1>
      <div className="loader"></div>
    </>
  );
};

export default Logout;
