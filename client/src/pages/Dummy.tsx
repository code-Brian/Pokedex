import { useEffect, useState } from 'react'
import axios from 'axios'

export const Dummy: React.FC = () => {
    const [testData,setTestData] = useState({
        name: "",
        email:"",
    })

    useEffect(() => {
        axios.get("/api/dummyData")
        .then((res:any) => {setTestData(res.data)})
        .catch((err:any) => console.log(err))
    }, [])

    return (
        <>
            <h1>Hello Reacc with data from .NET!</h1>
            <p>{testData.name}</p>
            <p>{testData.email}</p>
        </>
    )
}
