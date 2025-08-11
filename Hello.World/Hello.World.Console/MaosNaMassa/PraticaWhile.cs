using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.MaosNaMassa
{
    internal class PraticaWhile
    {
        public static void Executar()
        {
            double maior = double.MinValue; // Utiliza o menor valor possível do double
            double menor = double.MaxValue; // Utiliza o maior valor possível do double

            System.Console.WriteLine("Me informe um número, ou OK para sair :)");
            string entrada = System.Console.ReadLine();

            while (entrada.ToLower() != "ok") // Isso força o minusculo
            {
                if (double.TryParse(entrada, out double valor))
                {
                    maior = valor > maior ? valor : maior;
                    menor = valor < menor ? valor : menor;
                }
                else
                {
                    System.Console.WriteLine("Número inválido");
                }

                System.Console.WriteLine("Me informe um número, ou OK para sair :)");
                entrada = System.Console.ReadLine();
            }

            System.Console.WriteLine("Terminamos aqui:");
            System.Console.WriteLine($"Maior: {maior}");
            System.Console.WriteLine($"Menor: {menor}");
        }
    }
}