using OrientacaoObjetos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa
{
    public class Calculadora
    {
        public void RealizarOperacao()
        {
            switch (Sistema.LerChar("Informe o operador (+, -, / ou *)"))
            {
                case '+':
                    Somar(Sistema.LerInteiro("Informe o primeiro número"),
                  Sistema.LerInteiro("Informe o segundo número"));
                    break;
                case '-':
                    Subtracao(Sistema.LerInteiro("Informe o primeiro número"),
                  Sistema.LerInteiro("Informe o segundo número"));
                    break;
                case '*':
                    Multiplicacao(Sistema.LerInteiro("Informe o primeiro número"),
                  Sistema.LerInteiro("Informe o segundo número"));
                    break;
                case '/':
                    Divisao(Sistema.LerInteiro("Informe o primeiro número"),
                  Sistema.LerInteiro("Informe o segundo número"));
                    break;
                default:
                    Console.WriteLine("Inválido");
                    break;
            }
        }

        private void Somar(decimal numero1, decimal numero2)
        {
            Console.WriteLine($"Resultado: {numero1 + numero2}");
        }

        private void Subtracao(decimal numero1, decimal numero2)
        {
            Console.WriteLine($"Resultado: {numero1 - numero2}");
        }

        private void Multiplicacao(decimal numero1, decimal numero2)
        {
            Console.WriteLine($"Resultado: {numero1 * numero2}");
        }

        private void Divisao(decimal numero1, decimal numero2)
        {
            Console.WriteLine($"Resultado: {numero1 / numero2}");
        }
    }
}