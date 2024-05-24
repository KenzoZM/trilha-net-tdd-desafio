using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        List<string> Historico;
        private string data;
        public Calculadora(string data)
        {
            Historico = new List<string>();
            this.data = data;
        }
        public int Somar(int n1, int n2)
        {
            int res =  n1 + n2;
            string soma = $"Soma de {n1} + {n2} realizada com Sucesso resultado {res} - data {data}";
            Historico.Insert(0, soma);
            return res;
        }

        public int Subtrair(int n1, int n2)
        {
            int res = n1 - n2;
            string subtracao = $"Subtracao de {n1} + {n2} realizada com Sucesso resultado {res} - data {data}";
            Historico.Insert(0, subtracao);
            return res;
        }

        public double Multiplicar(int n1, int n2)
        {
            int res = n1 * n2;
            string multiplicacao = $"multiplicacao de {n1} + {n2} realizada com Sucesso resultado {res} - data {data}";
            Historico.Insert(0, multiplicacao);
            return res;
        }

        public double Dividir(int n1, int n2)
        {
            int res = n1 / n2;
            string divisao = $"divisao de {n1} + {n2} realizada com Sucesso resultado {res} - data {data}";
            Historico.Insert(0, divisao);
            return res;
        }

        public List<string> historico()
        {
            List<string> res;
            Historico.RemoveRange(3, Historico.Count - 3);
            return Historico;
        }
    }
}
