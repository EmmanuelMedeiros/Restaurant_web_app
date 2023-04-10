using ConsoleApp1.Entities;

Guarnicao a = new Guarnicao(1, "feijão", 4.00);
Guarnicao b = new Guarnicao(2, "arroz", 3.00);
Guarnicao c = new Guarnicao(3, "batata-frita", 7.00);
Guarnicao d = new Guarnicao(1, "purê", 5.00);
Guarnicao e = new Guarnicao(1, "pirão", 5.60);

PratoCompleto pratoA = new PratoCompleto(4, "Mista boi e porco comp.", "descrição do prato", 75.00);

pratoA.AddGuarnicao(a);
pratoA.AddGuarnicao(b);
pratoA.AddGuarnicao(a);

foreach (var item in pratoA._guarnicao) {
    Console.WriteLine(item.Name);
};

pratoA.FullValue();

Console.WriteLine(pratoA.ToString());