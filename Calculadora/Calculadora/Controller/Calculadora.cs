using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Calculadora
    {
        List<string> Historico = new List<string>(3);

        public int Soma(int val1, int val2)
        {
            var resultado = val1 + val2;
            GuardarHistorico($"{val1} + {val2} = {resultado}");
            return resultado;
        }

        public int Subtracao(int val1, int val2)
        {
            var resultado = val1 - val2;
            GuardarHistorico($"{val1} - {val2} = {resultado}");
            return resultado;
        }

        public int Multiplacao(int val1, int val2)
        {
            var resultado = val1 * val2;
            GuardarHistorico($"{val1} * {val2} = {resultado}");
            return resultado;
        }

        public int Divisao(int val1, int val2)
        {
            var resultado = val1 / val2;
            GuardarHistorico($"{val1} * {val2} = {resultado}");
            return resultado;
        }

        public List<string> RetornarHistorico()
        {
            return Historico;
        }

        public void GuardarHistorico(string calculo)
        {
            if(Historico.Count == 3) Historico.RemoveAt(0);
            Historico.Add(calculo);
        }
    }
}
