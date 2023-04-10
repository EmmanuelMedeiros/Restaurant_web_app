import "./styles/menuBar.css"
import HeaderBar from './HeaderBar'
import { useEffect, useState } from 'react'

function MenuBar() {

    const [actual_class, set_class] = useState()

    const Change_class = (value) => {
        set_class(value)

        console.log(actual_class)
    }

    const Close_menu = () => {
        set_class((previous_state) => {
            return "closed"
        })

        console.log(actual_class)
    }

    return(
        <div>
            <div className={actual_class == "open" ? "hide_it" : "show_it"}><HeaderBar throwData={Change_class}/></div>
            <div className="wrapper menu_container">
                <h1 onClick={Close_menu}>I'am header bar</h1>
            </div>
        </div>
    )
}

export default MenuBar