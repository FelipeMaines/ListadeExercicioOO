using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio03
{
    internal class VolumeCilindro
    {
        public int raio;
        public int altura;
        public double volume;

        public double CalcularVolumeCilindro()
        {
            volume = Math.Round(Math.Pow(raio, 2) * Math.PI * altura, 2);
            return volume;
        }
    }
}
