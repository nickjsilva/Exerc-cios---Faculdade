using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastosOO
{
    internal class ControleDeGastos
    {
        public List<Gasto> gastos = new List<Gasto>();
        public void AdicionarGasto(Gasto g)
        {
            gastos.Add(g);
        }
        public void ListarGastos()
        {
            //foreach (Gasto gasto in gastos)
            for (int i = 0; i < gastos.Count; i++)
            {
                Console.WriteLine("["+i+"]"+gastos[i]);
            }

            Console.WriteLine("Total de Gastos: R$ {0}", CalcularTotal());
        }
        public decimal CalcularTotal()
        {
            decimal total = 0;
            for (int i = 0; i < gastos.Count; i++)
            {
                total += gastos[i].valor;
            }
            return total;
        }
            
        public void ListarPorMesAno(int mes, int ano)
        {

            //foreach (Gasto gasto in gastos)
            for (int i = 0; i < gastos.Count; i++)
            {
                if (mes == gastos[i].mes && ano == gastos[i].ano)
                    Console.WriteLine("[" + i + "]" + gastos[i]);
            }
        }
    }
}
