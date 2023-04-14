import "./styles/headerBar.css"

function HeaderBar(props) {
  
  return (
    <div className="wrapper header_container">
      <ul>
        <li>
          <h1>B</h1>
        </li>
        <li onClick={props.onMenuClick}><span class="material-icons md-18">menu</span></li>
      </ul>
    </div>
  );
}


export default HeaderBar