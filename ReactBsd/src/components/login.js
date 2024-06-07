
// import { useEffect, useState,useRef } from "react";
// const Login=()=>{
//     const UserName = useRef("")
//     const Password = useRef("")
//     return(
//         <>
//         <input placeholder="UserName"   onChange={(event) => UserName.current = (event.target.value)}></input>
//         <input placeholder="Password" onChange={(event) => Password.current = (event.target.value)}></input>
//         </>
//     )
// }

import { useRef } from "react";
import { useNavigate } from "react-router-dom";
import axios from 'axios';
axios.defaults.baseURL = "http://localhost:5084";
const Login = () => {
    const name = useRef('');
    const password = useRef('');


    const navigate = useNavigate()

    const login = () => {
     
        // axios.post('/User/Login', {
        //     "userId": name.current,
        //     "password": password.current
        // })
        axios
            .post(
                "/Customer/get/",
            {
                "Email": email.current,
                
            }
                // {
                //     headers: {
                //         'Content-Type': 'application/json',
                //         'Access-Control-Allow-Origin': '*',
                //     },
                // },
            )
            .then(function (response) {
                
                if (response.data.statusCode === 200) {
                    //localStorage.removeItem("userId");
                   // localStorage.setItem('userId', name.current);
                    navigate("./ViewGift", { replace: false });
                }
                else {
                    alert("אינך רשום במערכת הנך מועבר לרישום")
                    navigate("./register", { replace: false });
                }
            })
            .catch(function (error) {
            });
           
    }

    return (

        <div className="App">
            <h1>שם משתמש</h1>
            <input placeholder="מייל" onChange={(event) => name.current = (event.target.value)}></input>
            <br></br>
            <h1>סיסמה</h1>
            <input placeholder="סיסמה" onChange={(event) => password.current = (event.target.value)}></input>
            <br></br>
            <button onClick={() => login()}>לכניסה למערכת</button>
        </div>

    )
}
export default Login