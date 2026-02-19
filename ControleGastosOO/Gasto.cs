using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastosOO
{
    internal class Gasto
    {
        public string descricao;
        public decimal valor;
        public int mes;
        public int ano;

        //Construtor
        public Gasto(string descricao, decimal valor, int mes, int ano)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.mes = mes;
            this.ano = ano;
        }
        
        override 
        public  string ToString()
        {
            return " [Descrição: "+ descricao+", Valor: "+ valor + ", Mês: "+mes + ", Ano: "+ano + "]";
        }
    }
}
