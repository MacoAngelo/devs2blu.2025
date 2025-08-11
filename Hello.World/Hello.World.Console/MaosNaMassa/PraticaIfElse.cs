using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.MaosNaMassa
{
    internal class PraticaIfElse
    {
        public static void Executar()
        {
            System.Console.WriteLine("Informe o seu nome!");
            var nome = System.Console.ReadLine();

            if (nome == "Ana" 
                || nome == "Maria" 
                || nome == "João" 
                || nome == "José" 
                || nome == "Carlos")
            {
                System.Console.WriteLine($"Pode entrar {nome}!");
            }
            else
            {

                System.Console.WriteLine($"Desculpe {nome}, mas seu nome não está na lista!");
            }
        }
    }
}
