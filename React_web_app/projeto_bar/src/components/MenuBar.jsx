import "./styles/menuBar.css"
import HeaderBar from './HeaderBar'
import { useEffect, useState } from 'react'

function MenuBar() {
    const [isOpen, setOpen] = useState(false);
  
    return (
      <div>
        <div className={isOpen ? 'hide_it' : 'show_it'}>
          <HeaderBar isOpen={isOpen} onMenuClick={() => setOpen(true)} />
        </div>
        <div className="wrapper menu_container">
          <h1 onClick={() => setOpen(false)}>I'am header bar</h1>
        </div>
      </div>
    );
  }

export default MenuBar