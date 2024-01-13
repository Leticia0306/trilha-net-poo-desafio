using DesafioPOO.Models;

//IMPLEMENTADO
class Program
{
    static void Main()
    {
        //IMPLEMENTADO
        //Foi criado instâncias de Nokia
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "(11)93344-5009", modelo: "Nokia XR20", imei: "102030405", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("\n");
        
        //IMPLEMENTADO
        //Foi criado instâncias do Iphone
        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "(11)96698-8544", modelo: "Iphone 15", imei: "152535455", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Youtube");

        //Aguarda a entrada do usuário antes de encerrar o programa
        Console.ReadLine();
        
    }
}