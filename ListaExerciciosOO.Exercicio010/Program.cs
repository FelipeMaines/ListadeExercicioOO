namespace ListaExerciciosOO.Exercicio010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ponderada notas = new Ponderada();

            notas.nota1 = 10;
            notas.nota2 = 6;
            notas.nota3 = 3;

            notas.peso3 = 4;
            notas.peso2 = 1;
            notas.peso3 = 2;

            Console.WriteLine($"A media ponderada dah: {notas.CalcularPonderada()}");

        }
    }
}