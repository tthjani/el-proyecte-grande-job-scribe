import React from 'react'
import ReactDOM from 'react-dom/client'
import { createBrowserRouter, RouterProvider } from "react-router-dom";
import App from "./App.jsx";
import Registration from "./Components/Registration"
import CompanyReg from "./Components/CompanyReg"
import UserLogin from './Components/UserLogin.jsx';
import './index.css'


const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      {
        path: "/userregistration",
        element: <Registration />,
      },
      {
        path: "/companyregistration",
        element: <CompanyReg />,
      },
      {
        path: "/userlogin",
        element: <UserLogin />,
      },
    ],
  },
]);

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>,
)
