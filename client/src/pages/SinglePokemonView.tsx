import {useEffect, useState} from 'react'
import axios from 'axios'
import {SinglePokemon} from '../types/Pokemon.types'
import {Pokemon} from '../components/Pokemon'


export const SinglePokemonView = () => {
    const [pokemonInfo, setPokemonInfo] = useState<SinglePokemon>()

    useEffect(() => {
        axios.get("/api/pokemon")
        .then((res:any) => {setPokemonInfo(res.data)})
        .catch((err:any)=>{console.log(err)})
    },[])

    return (
        <Pokemon id={pokemonInfo!.id} name={pokemonInfo!.name} abilities={pokemonInfo!.abilities} sprites={pokemonInfo!.sprites} types={pokemonInfo!.types}/>
    )
}
