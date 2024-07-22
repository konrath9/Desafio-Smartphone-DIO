namespace SistemaSmatphone.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo \"{nome}\" no Nokia");
        }
    }
}
