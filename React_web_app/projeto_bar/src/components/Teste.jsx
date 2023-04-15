function Teste() {

    const dados = [
        {
            name: "A",
            idade: 2
        },
        {
            name: "B",
            idade: 3
        }
    ]

    return(
        <div>
            <h1>Testes</h1>
            {dados.map(element => (
                <ul>
                    <li>name: {element.name}</li>
                    <li>idade: {element.idade}</li>
                </ul>
            ))}
        </div>
    )
}

export default Teste