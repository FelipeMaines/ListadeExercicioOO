using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosOO.Exercicio010
{
    internal class Ponderada
    {
        public int nota1;
        public int nota2;
        public int nota3;

        public int peso1;
        public int peso2;
        public int peso3;

        public double CalcularPonderada()
        {
           return ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / (peso1 + peso2 + peso3);
        }
    }
}
