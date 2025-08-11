using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.Exercicios
{
    internal class ArrayNumeroDois
    {
        public static void Executar()
        {
            int menor = int.MaxValue;
            int maior = int.MinValue;
            var numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                System.Console.WriteLine("Informe um número inteiro");
                var numero = int.Parse(System.Console.ReadLine());

                numeros[i] = numero;
                maior = numero > maior ? numero : maior;
                menor = numero < menor ? numero : menor;
            }

            System.Console.WriteLine($"Maior: {maior}");
            System.Console.WriteLine($"Menor: {menor}");
        }
    }
}