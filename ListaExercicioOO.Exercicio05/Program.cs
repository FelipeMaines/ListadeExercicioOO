namespace ListaExercicioOO.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Esfera esfera = new Esfera();

            esfera.raio = 5;

            Console.WriteLine($"O volume final ficou com {esfera.CalcularVolumeEsfera()}");


        }
    }
}