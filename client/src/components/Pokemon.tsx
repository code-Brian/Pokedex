import {useState, useEffect} from 'react'
import {SinglePokemon} from '../types/Pokemon.types'

export const Pokemon: React.FC<SinglePokemon> = ({id, name, abilities, sprites, types}) => {

return (
    <>
        <div>
            <h2>Pokemon: {name} | ID: {id}</h2>
            <ul>
                <li>
                    <ul>
                    </ul>
                </li>
            </ul>
        </div>
    </>
)
}