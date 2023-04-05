using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercicioOO.Exercicio1
{
    internal class cubo
    {

        public int altura;
        public int comprimento;
        public int largura;

        public decimal calcularArea()
        {
            return altura * largura * comprimento;
        }
    }
}
