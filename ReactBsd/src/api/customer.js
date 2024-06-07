import axios from 'axios';

axios.defaults.baseURL = "http://localhost:5084";
export const getAllGift = async () => {
    return await axios.get('/Gift')

        .then((response) => {
            return response
        })
        .catch((error) => {

            console.log("api_getAllGift",error) 
        });
}
const login = (email) => {
     
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
            //     // headers: {
            //     //     'Content-Type': 'application/json',
            //     //     'Access-Control-Allow-Origin': '*',
            //     // },
            // },
        )
        .then(function (response) {
            
            if (response.data.statusCode === 200) {
                //localStorage.removeItem("userId");
                //localStorage.setItem('userId', name.current);
                navigate("./Calendar", { replace: false });
            }
            else {
                alert("אינך רשום במערכת הנך מועבר לרישום")
                navigate("./register", { replace: false });
            }
        })
        .catch(function (error) {
        });
       
}