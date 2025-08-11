using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.MaosNaMassa
{
    internal class PraticaForeach
    {
        public static void Executar()
        {
            bool continua = false;
            List<string> nomes = new List<string>();

            do
            {
                System.Console.Clear();
                System.Console.WriteLine("Informe o nome do aluno");
                var nome = System.Console.ReadLine();

                if (nome.ToLower() == "ok")
                {
                    continua = false;
                }
                else
                {
                    nomes.Add(nome);
                    continua = true;
                }
            } while (continua);

            System.Console.Clear();
            System.Console.WriteLine("Cadastrada turma");
            System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=");

            int contagem = 1;
            foreach (var nome in nomes)
            {
                System.Console.WriteLine($"#{contagem}\t{nome}");
                contagem++;
            }
            System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}