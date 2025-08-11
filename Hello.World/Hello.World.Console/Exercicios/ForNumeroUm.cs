using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.Exercicios
{
    internal class ForNumeroUm
    {
        public static void Executar()
        {
            System.Console.WriteLine("Informe um número positivo");
            int numero = int.Parse(System.Console.ReadLine());

            if (numero == 0)
            {
                System.Console.WriteLine("O fatorial de 0 é igual a 1 por definição!");
            }
            else
            {
                string saida = $"{numero}";
                int resultado = numero;

                //System.Console.Write(numero);
                for (int controle = numero - 1; controle > 0; controle--)
                {
                    saida += $"x{controle}";
                    resultado *= controle;
                    //System.Console.Write($"x{controle}");
                }

                //System.Console.Write($" = {resultado}");

                saida += $" = {resultado}";
                System.Console.WriteLine(saida);
            }
        }
    }
}
