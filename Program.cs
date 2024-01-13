using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.Write ("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1234",modelo: "nokia123",imei: "0800",memoria: 128);

nokia.Ligar();
nokia.InstalarAplicativo("Minecraft");


Console.WriteLine("/n");


Console.Write ("Smartphone Nokia: ");
Smartphone iphone = new Iphone(numero: "7889",modelo: "Iponei",imei: "4563",memoria: 256);

iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
