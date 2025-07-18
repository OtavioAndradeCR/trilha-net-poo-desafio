using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "99999-1111", modelo: "Nokia Tijolão", imei: "123456789", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone iPhone:");
        Smartphone iphone = new Iphone(numero: "88888-2222", modelo: "iPhone 13", imei: "987654321", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
