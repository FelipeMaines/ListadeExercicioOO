using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio02
{
    internal class ConverterTemp
    {
        public int temperaturaF;
        public int celcius;

        public decimal ConverterTemperatura()
        {
            celcius = (int)((temperaturaF - 32) / 1.8);
            return celcius;
        }

    }
}
