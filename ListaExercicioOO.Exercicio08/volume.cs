using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio08
{
    internal class volume
    {
        public int altura;
        public double raio;
        

        public double RetornarVolume()
        {
            return Math.Round(altura * Math.Pow(raio, 2) * Math.PI, 2);
            
        }
    }
}
