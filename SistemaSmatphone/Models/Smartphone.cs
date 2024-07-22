namespace SistemaSmatphone.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private readonly string Modelo;
        private readonly string IMEI;
        private readonly int Memoria;

        protected Smartphone()
        {
        }

        protected Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}
