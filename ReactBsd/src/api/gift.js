import axios from 'axios';
import { useNavigate } from "react-router-dom";
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