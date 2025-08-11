using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.Exercicios
{
    internal class ArrayNumeroTres
    {
        public static void Executar()
        {
            var nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                System.Console.WriteLine("Informe um nome");
                var nome = System.Console.ReadLine();

                nomes[i] = nome;
            }

            for (int i = nomes.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine(nomes[i]);
            }
        }
    }
}