using DesafioPOO.Models;

//--------IPHONE------------------
Console.WriteLine("--------------IPHONE----------------");

Iphone i = new Iphone("55",3541,5555555,128);
i.InstalarAplicativo("Chrome");
i.ReceberLigacao();
i.Ligar();

//--------------NOKIA-----------------
Console.WriteLine("--------------NOKIA-----------------");
Nokia nokia = new Nokia("3541",556,3542,64);
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();
nokia.Ligar();

// TODO: Realizar os testes com as classes Nokia e Iphone