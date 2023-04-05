using System.Security.Cryptography.X509Certificates;

namespace ListaExercicioOO.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Harmonica notas = new Harmonica();

            notas.nota1 = 6;
            notas.nota2 = 7;
            notas.nota3 = 8;


            Console.WriteLine($"A nota harmonica ficou em {notas.CalculaNotaHarmnica()}");
        }
    }
}