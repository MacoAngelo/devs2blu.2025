using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.Exercicios
{
    public enum DiaSemana
    {
        Domingo = 1,
        Segunda = 2,
        Terca = 3,
        Quarta = 4,
        Quinta = 5,
        Sexta = 6,
        Sabado = 7,
    }

    internal class SwitchNumeroZero
    {
        public static void Executar ()
        {
            System.Console.WriteLine("Informe um número");
            int numero = int.Parse(System.Console.ReadLine());

            // Tratamento para número que não seja 1-7

            //switch ((DiaSemana)numero)
            //{
            //    case DiaSemana.Domingo:
            //        System.Console.WriteLine("Domingo");
            //        break;
            //    case DiaSemana.Segunda:
            //        System.Console.WriteLine("Segunda-feira");
            //        break;
            //    case DiaSemana.Terca:
            //        System.Console.WriteLine("Terça-feira");
            //        break;
            //    case DiaSemana.Quarta:
            //        System.Console.WriteLine("Quarta-feira");
            //        break;
            //    case DiaSemana.Quinta:
            //        System.Console.WriteLine("Quinta-feira");
            //        break;
            //    case DiaSemana.Sexta:
            //        System.Console.WriteLine("Sexta-feira");
            //        break;
            //    case DiaSemana.Sabado:
            //        System.Console.WriteLine("Sabado");
            //        break;
            //}

            System.Console.WriteLine(((DiaSemana)numero).ToString());
        }
    }
}
