/*OS DADOS SERÃO ENVIADOS PARA ESSA TELA ATRAVÉS DE PROPS*/
import { useEffect, useState } from "react"
import axios from "axios"
import "./styles/dataScreen.css"


function DataScreen() {

    const [data, data_set] = useState([])

    useEffect(() => {
        axios.get('https://localhost:7159/Prato/pratos_completos')
        .then(response => {
            data_set(response.data)
        })
    }, [])

    
    return(
        <div className="wrapper data_screen_container">
            {data.map(element => (
                <ul className="data">
                    <li>---IMAGEM---</li>
                    <li>{element.name}</li>
                    <li>R$ {element.value}</li>
                </ul>
            ))}
        </div>
    )
}

export default DataScreen