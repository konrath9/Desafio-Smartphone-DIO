using SistemaSmatphone.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", iMEI: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "7891234", modelo: "Modelo 2", iMEI: "2222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");