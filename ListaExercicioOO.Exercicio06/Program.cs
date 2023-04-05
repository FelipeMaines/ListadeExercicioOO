namespace ListaExercicioOO.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConveterTemp temp = new ConveterTemp();

            temp.celcius = 10;

            Console.WriteLine($"A temp fica em {temp.ConverterCelciustoF()}");
        }
    }
}