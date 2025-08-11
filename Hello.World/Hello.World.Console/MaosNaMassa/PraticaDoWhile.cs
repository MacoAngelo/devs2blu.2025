using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.MaosNaMassa
{
    internal class PraticaDoWhile
    {
        const string SENHA = "B@linha1";

        public static void Executar()
        {
            bool login = false;

            do
            {
                System.Console.WriteLine("Informe a senha de acesso ao terminal!");
                var senhaEntrada = System.Console.ReadLine();

                login = senhaEntrada == SENHA;
            } while (!login);

            System.Console.Clear();
            System.Console.WriteLine("Bem-vindo ao super terminal dos alunos");
        }
    }
}