using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trilha_net_testes_unitarios_desafio_calculadora.console
{
    public class Calculadora
    {
        private List<string> _historico;

        public Calculadora() 
        {
            _historico = new List<string>(); 
        }

        public int Somar(int num1, int num2)
        { 
            int resultado = num1 + num2;
            AdicionarHistorico(num1, num2, resultado, "+");
            return resultado; 
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            AdicionarHistorico(num1, num2, resultado, "-");
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            AdicionarHistorico(num1, num2, resultado, "*");
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            AdicionarHistorico(num1, num2, resultado, "/");
            return resultado;
        }

        private void AdicionarHistorico(int num1, int num2, int resultado, string operador) 
        {
            _historico.Insert(0,$"{num1} {operador} {num2} = {resultado}");
        }


        public List<string> ObterHistorico() 
        {
            var lista = _historico.Take(3).ToList();
            return lista;
        }



    }
}
