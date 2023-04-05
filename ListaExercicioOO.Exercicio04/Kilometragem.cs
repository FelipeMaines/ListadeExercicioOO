using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio04
{
    internal class Kilometragem
    {
        public int kmInicial;
        public int kmFinal;
        public int litrosGastos;
        public int gastoGasolina;

        public int CalcularGastoGasosa()
        {
            return (kmFinal - kmInicial) / litrosGastos;
        }

    }
}
