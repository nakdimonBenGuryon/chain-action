
import { useEffect, useState,useRef } from "react";
import {getAllGift} from "../api/gift"
const View=()=>{
    const [arr, setArr] = useState([])
    const ArrCardOfPurches = useRef([])
    const loadGifts = async () => {
        await getAllGift().then((res) => 
          {
            
            setArr(res.data)
            
          }) 
}
useEffect(() => {
    loadGifts()
    
  }, [])
const addToPacage=(item)=>{
 ArrCardOfPurches.current=([...ArrCardOfPurches.current,item])
console.log("arr",ArrCardOfPurches.current)
}
  return(
    <div>
    <div style={{"display" : "flex"}}>
       {arr.map((i)=><div ><div>{i.name}</div><div>{i.price}</div><button onClick={()=>(addToPacage(i))}>+</button><button onClick={()=>(addToPacage(i))}>הוסף לסל</button><button onClick={()=>(addToPacage(i))}>-</button></div>)}
       </div>
       <button>אישור רכישה</button>
       </div>
    )
}
export default View;