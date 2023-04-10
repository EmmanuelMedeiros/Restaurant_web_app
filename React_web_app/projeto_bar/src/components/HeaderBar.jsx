import "./styles/headerBar.css"

import { useEffect, useState } from 'react'

function HeaderBar(props) {

    const [state, set_state] = useState()
    
    const OnClickHandler = () => {
        if(state != "open") {

            set_state("open")
        } else if(state == "open") {

            set_state("closed")
        }
    }

    useEffect(() => {
        props.throwData(state)
    })

    return(
        <div className='wrapper header_container'>
            <ul>
                <li><h1 className={state == "oppened" ? "green" : "black"}>B</h1></li>
                <li onClick={OnClickHandler}><span class="material-icons md-18">menu</span></li>
            </ul>
        </div>
    )
}

export default HeaderBar