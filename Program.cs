using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("213213", "modelo 1", "213123213213", 2);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("Smartphone Nokia");
Smartphone iphone = new Iphone("213213", "modelo 1", "213123213213", 2);
iphone.Ligar();
iphone.InstalarAplicativo("telegram");