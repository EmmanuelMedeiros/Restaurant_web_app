
import HeaderBar from './HeaderBar'
import { useEffect, useState } from 'react'

function MenuBar() {

    const [actual_class, set_class] = useState()

    const Change_class = (value) => {
        set_class(value)

        console.log(actual_class)
    }

    useEffect(() => {
        console.log(`Minha classe atual é ${actual_class}`)
    }, [actual_class])
    

    return(
        <div>
            <HeaderBar throwData={Change_class}/>
            <div className="wrapper menu_container">
                <h1>I'am header bar</h1>
            </div>
        </div>
    )
}

export default MenuBar