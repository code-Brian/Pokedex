import './App.css'
import { Routes, Route, Link } from 'react-router-dom'
import {Dummy} from './pages/Dummy'
import {SinglePokemonView} from './pages/SinglePokemonView'

function App() {
  return (
    <>
      <h1>HENLO FROM CLIENT APP</h1>
      <Link to="/">Dummy</Link>
      <Routes>
        <Route path="/" element={<Dummy />}/>
        <Route path="/pokemon" element={<SinglePokemonView />}/>
      </Routes>
    </>
  )
}

export default App
