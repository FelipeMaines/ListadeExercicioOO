using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio07
{
    internal class TotalSalario
    {
        public int totalDeVendas;
        public decimal baseSalario;
        public decimal porcentual;

        public decimal CalculaSalario()
        {
            return baseSalario + (totalDeVendas * porcentual);
        }


    }
}
