namespace ListadeExercicioOO.Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cubo caixa = new cubo();

            caixa.altura = 10;
            caixa.largura = 20;
            caixa.comprimento = 20;

            Console.WriteLine($"A area ficou em {caixa.calcularArea()}");






        }
    }
}