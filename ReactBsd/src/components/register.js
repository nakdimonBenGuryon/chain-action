import { useRef } from "react";
import { useNavigate } from "react-router-dom";
import axios from 'axios';

axios.defaults.baseURL="http://localhost:5102";

const Register=()=>{
   const navigate=useNavigate()
    const firstName= useRef('');
    const lastName= useRef('');
    const password= useRef('');
    const email = useRef('');
    const phonNumber = useRef('');
    const city = useRef('');

    
 const register = () => {
  
    axios.post('/Customer', {  
        "city":city.current,
        "password":password.current,
        "email":email.current,
        "phone":phonNumber.current,
        "lastName": lastName.current,
        "firstName":firstName.current

      })
      .then(function (response) {
        localStorage.removeItem("userId");
        localStorage.setItem('userId', userId.current);
        navigate("../Calendar", { replace: false }) 
      })
      .catch(function (error) {
        console.log(error)
      });
    }
return(
    <div className="App">
    <h1>שם משתמש</h1>
    <input placeholder="עיר"onChange={(event)=>city.current=event.target.value}></input>
    <br></br>
    <h1>סיסמה</h1>
    <input placeholder="סיסמה" onChange={(event)=>password.current=event.target.value}></input>
    <h1>שם פרטי</h1>
    <input placeholder="שם פרטי" onChange={(event)=>firstName.current=event.target.value}></input>
    <h1>שם משפחה</h1>
    <input placeholder="שם משפחה" onChange={(event)=>lastName.current=event.target.value}></input>
    <br></br>
    <h1>אימייל</h1>
    <input placeholder="אימייל" onChange={(event)=>email.current=event.target.value}></input>
    <br></br>
    <h1>מספר פלאפון</h1>
    <input placeholder="מספר פלאפון" onChange={(event)=>phonNumber.current=event.target.value}></input>
    <br></br>
    <button onClick={()=>register()}>לכניסה למערכת</button>
    </div>
    
)
}
export default Register;