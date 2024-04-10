using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Nokia celularNokia = new Nokia( "11987654321", "Nokia 3210", "1234567890", 128);
Console.WriteLine("Nokia");
celularNokia.Ligar();
celularNokia.ReceberLigacao();
celularNokia.InstalarAplicativo("primevideo");

Console.WriteLine("-------------------------");
Iphone celularIphone = new Iphone( "16667654321", "Iphone 4210", "12555567890", 128);
Console.WriteLine("Iphone");
celularIphone.Ligar();
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("Whatsapp");   

