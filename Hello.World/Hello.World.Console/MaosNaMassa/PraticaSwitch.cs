using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.MaosNaMassa
{
    internal class PraticaSwitch
    {
        public static void Executar()
        {
            System.Console.WriteLine("Me informe o seu nome pfvr!");
            var nome = System.Console.ReadLine();
            var primeiraLetra = nome[0]; // Esse cara pega a primeira letra do nome

            switch (primeiraLetra)
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'G':
                case 'H':
                case 'I':
                case 'J':
                    System.Console.WriteLine($"{nome}, vá para a fila de número 2!");
                    break;

                case 'K':
                    System.Console.WriteLine($"{nome}, vá para a fila de número 1!");
                    break;

                case 'T':
                    System.Console.WriteLine($"{nome}, vá para a fila de número 3!");
                    break;
                default:
                    System.Console.WriteLine("Informe um nome válido!");
                    break;
            }
        }
    }
}