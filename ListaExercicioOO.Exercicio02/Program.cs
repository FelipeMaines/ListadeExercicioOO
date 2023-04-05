namespace ListaExercicioOO.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C=(F-32)/1,8.

            ConverterTemp temp = new ConverterTemp();

            temp.temperaturaF = 50;
            temp.celcius = 0;

            Console.WriteLine($"O resultado final fica em {temp.ConverterTemperatura()}");
        }
    }
}