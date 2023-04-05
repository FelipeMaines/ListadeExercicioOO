namespace ListaExercicioOO.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Kilometragem kilometro = new Kilometragem();

            kilometro.kmInicial = 10;
            kilometro.kmFinal = 100;
            kilometro.litrosGastos = 10;

            Console.WriteLine(kilometro.CalcularGastoGasosa());

        }
    }
}