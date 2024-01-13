namespace DesafioPOO.Models
{
    //IMPLEMENTADO
    //Foi herdado a classe "Smartphone"
    public class Nokia : Smartphone
    {
        //IMPLEMENTADO
        //Foi criado o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}