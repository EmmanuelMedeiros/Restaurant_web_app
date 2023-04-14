import "./styles/menuBar.css"
import HeaderBar from './HeaderBar'
import { useEffect, useState } from 'react'

function MenuBar() {
    const [isOpen, setOpen] = useState(false);
    const [menuOpen, setMenuOpen] = useState(false);
  
    return (
      <div>
        <div className={isOpen ? 'hide_it' : 'show_it'}>
          <HeaderBar onMenuClick={() => setOpen(true)} />
        </div>
        <div className={isOpen ? 'wrapper menu_container' : 'hide_menu'}>

          <ul className="top_bar">
            <li><h1>B</h1></li>
            <li onClick={() => setOpen(false)}><span class='material-icons md-18'>close</span></li>
          </ul>

          <ul className="items">
            <li onClick={menuOpen ? () => setMenuOpen(false) : () => setMenuOpen(true)} ><h2>+ Menu</h2></li>
            <li className={menuOpen ? "menu_itens" : "menu_closed"}>Pratos completos</li>
            <li className={menuOpen ? "menu_itens" : "menu_closed"}>Tira-gostos</li>
            <li className={menuOpen ? "menu_itens" : "menu_closed"}>Bebidas</li>
            <li><h2>Contato</h2></li>
          </ul>
          
        </div>
      </div>
    );
  }

export default MenuBar