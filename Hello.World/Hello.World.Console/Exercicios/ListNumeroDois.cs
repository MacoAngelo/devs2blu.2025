using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.Exercicios
{
    internal class ListNumeroDois
    {
        const int QUANTIDADE_TENTATIVAS = 3;

        public static void Executar()
        {
            List<int> meusNumeros = new List<int>() { 1, 2, 56, 26, 89, 78, 64, 21, 13, 66 };

            for (int i = 0; i < QUANTIDADE_TENTATIVAS; i++)
            {
                System.Console.WriteLine($"Tentativas restantes: {QUANTIDADE_TENTATIVAS - (i + 1)}");
                System.Console.WriteLine("Informe um número de 1 a 100");
                //var numero = int.Parse(System.Console.ReadLine());
                var entrada = System.Console.ReadLine();

                if (!int.TryParse(entrada, out int numero) || numero < 1 || numero > 100)
                {
                    System.Console.WriteLine("Número inválido, você perdeu uma tentativa!");
                }
                else
                {
                    // Opção 01
                    // bool acertou = false;

                    // Opção 02
                    string saida = "Não acertou";

                    //FOR -> for (int i = 0; i < meusNumeros.Count; i++)
                    foreach (var numeroLista in meusNumeros) // foreach
                    {
                        // Opção 01
                        //if (meusNumeros[i] == numero)
                        //{
                        //    acertou = true;
                        //}

                        // Opção 02
                        //FOR -> if (meusNumeros[i] == numero)
                        if (numeroLista == numero) // foreach
                        {
                            saida = "Acertou";
                            break; // Quando dentro do For, While, Foreach ou Do-While -> Para de executar o laço
                        }
                    }

                    System.Console.WriteLine(saida);

                    // Opção 01
                    //if (acertou)
                    //{
                    //    System.Console.WriteLine("Acertou!");
                    //}
                    //else
                    //{
                    //    System.Console.WriteLine("Não acertou");
                    //}
                }
            }
        }
    }
}
