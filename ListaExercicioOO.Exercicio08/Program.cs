namespace ListaExercicioOO.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            volume lata = new volume();

            lata.raio = 10;
            lata.altura = 20;

            Console.WriteLine($"O volume eh {lata.RetornarVolume()}");
        }
    }
}