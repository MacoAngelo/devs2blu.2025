using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.MaosNaMassa
{
    internal class PraticaLista
    {
        public static void Executar()
        {
            List<string> nomes = new List<string>();
            List<double> notas = new List<double>();

            System.Console.WriteLine("Informe o nome do aluno!");
            nomes.Add(System.Console.ReadLine());
            System.Console.WriteLine($"Informe a nota do(a) {nomes[0]}");
            notas.Add(double.Parse(System.Console.ReadLine()));

            System.Console.WriteLine("Informe o nome do aluno!");
            nomes.Add(System.Console.ReadLine());
            System.Console.WriteLine($"Informe a nota do(a) {nomes[1]}");
            notas.Add(double.Parse(System.Console.ReadLine()));

            System.Console.WriteLine("Informe o nome do aluno!");
            nomes.Add(System.Console.ReadLine());
            System.Console.WriteLine($"Informe a nota do(a) {nomes[2]}");
            notas.Add(double.Parse(System.Console.ReadLine()));

            System.Console.WriteLine("Informe o nome do aluno!");
            nomes.Add(System.Console.ReadLine());
            System.Console.WriteLine($"Informe a nota do(a) {nomes[3]}");
            notas.Add(double.Parse(System.Console.ReadLine()));

            System.Console.WriteLine("Informe o nome do aluno!");
            nomes.Add(System.Console.ReadLine());
            System.Console.WriteLine($"Informe a nota do(a) {nomes[4]}");
            notas.Add(double.Parse(System.Console.ReadLine()));

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
