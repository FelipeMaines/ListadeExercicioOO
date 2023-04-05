using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio05
{
    internal class Esfera
    {

        public double raio;
        public double volume;

        public double CalcularVolumeEsfera()
        {
            volume = (4/3) * Math.PI * Math.Pow(raio, 3);
            return Math.Round(volume, 2);
        }

    }
}
