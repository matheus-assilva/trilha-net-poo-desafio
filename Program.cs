using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "912345678", modelo: "Tijolo", imei: "123456", memoria: 15);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");


Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987465432", modelo: "Estevão Trabalhos", imei: "654321", memoria: 25);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
iphone.InstalarAplicativo("Twitter");

