import {useEffect, useState} from 'react'
import axios from 'axios'
import {Pokemon} from '../components/Pokemon'


export const SinglePokemonView = () => {
    const [pokemonInfo, setPokemonInfo] = useState()
    useEffect(() => {
        axios.get("/api/pokemon")
        .then((res:any) => {setPokemonInfo(res.data)})
        .catch((err:any)=>{console.log(err)})
    },[])

    console.log(pokemonInfo);

    return (
        <Pokemon />
    )
}
