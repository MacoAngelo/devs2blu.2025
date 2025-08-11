using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.MaosNaMassa
{
    internal class PraticaArray
    {
        public static void Executar()
        {
            string[] nomes = new string[5];
            double[] notas = new double[5];

            System.Console.WriteLine("Informe o nome do aluno!");
            nomes[0] = System.Console.ReadLine();
            System.Console.WriteLine($"Informe a nota do(a) {nomes[0]}");
            notas[0] = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Informe o nome do aluno!");
            nomes[1] = System.Console.ReadLine();
            System.Console.WriteLine($"Informe a nota do(a) {nomes[1]}");
            notas[1] = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Informe o nome do aluno!");
            nomes[2] = System.Console.ReadLine();
            System.Console.WriteLine($"Informe a nota do(a) {nomes[2]}");
            notas[2] = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Informe o nome do aluno!");
            nomes[3] = System.Console.ReadLine();
            System.Console.WriteLine($"Informe a nota do(a) {nomes[3]}");
            notas[3] = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Informe o nome do aluno!");
            nomes[4] = System.Console.ReadLine();
            System.Console.WriteLine($"Informe a nota do(a) {nomes[4]}");
            notas[4] = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("");
            System.Console.WriteLine("Notas dos alunos");
            System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            System.Console.WriteLine($"{nomes[0]}:\t\t\t{notas[0]}");
            System.Console.WriteLine($"{nomes[1]}:\t\t\t{notas[1]}");
            System.Console.WriteLine($"{nomes[2]}:\t\t\t{notas[2]}");
            System.Console.WriteLine($"{nomes[3]}:\t\t\t{notas[3]}");
            System.Console.WriteLine($"{nomes[4]}:\t\t\t{notas[4]}");
            System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}
