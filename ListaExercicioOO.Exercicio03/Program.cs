namespace ListaExercicioOO.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VolumeCilindro volume = new VolumeCilindro();

            volume.raio = 10;
            volume.altura = 20;
            

            Console.WriteLine($"O volume fica em {volume.CalcularVolumeCilindro()}");
        }
    }
}