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
            volume = Math.Round((raio * raio) * Math.PI * altura);
            return volume;
        }
    }
}
