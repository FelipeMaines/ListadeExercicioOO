using ListaExercicioOO.Exercicio07;

namespace ListaExercicio.Exercicio007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TotalSalario salario = new TotalSalario();

            salario.totalDeVendas = 100000;
            salario.porcentual =(decimal) 0.1; 
            salario.baseSalario = 1000;

            Console.WriteLine($"O salario final fica em {salario.CalculaSalario()}");
        }
    }
}