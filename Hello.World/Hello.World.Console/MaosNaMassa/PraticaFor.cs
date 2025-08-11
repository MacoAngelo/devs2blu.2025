using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.MaosNaMassa
{
    internal class PraticaFor
    {
        public static void Executar()
        {
            System.Console.WriteLine("Me informe um número!");
            int numero = int.Parse(System.Console.ReadLine());

            System.Console.Clear();
            System.Console.WriteLine($"Super tabuada do número {numero}");
            for (int i = 0; i < 10; i++)
            {
                int multiplicador = i + 1;
                int resultado = multiplicador * numero;

                System.Console.WriteLine($"{numero}\tx\t{multiplicador}\t=\t{resultado}");
            }
        }
    }
}