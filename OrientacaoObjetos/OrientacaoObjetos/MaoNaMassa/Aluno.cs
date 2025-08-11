using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa
{
    public class Aluno
    {
        private const int QUANTIDADE_MESES_ANO = 12;

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Matricula { get; set; }



        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public Aluno(string nome, int idade, string matricula)
        {
            Nome = nome;
            Idade = idade;
            Matricula = matricula;
        }

        public void CalcularIdadeEmMeses()
        {
            Console.WriteLine($"A idade do(a) {Nome} em meses é: {Idade * QUANTIDADE_MESES_ANO} meses.");
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Apresentação do aluno");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Matrícula: {Matricula}");
        }

        public void ExibirInfoSb()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Apresentação do aluno");
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"Idade: {Idade}");
            sb.AppendLine($"Matrícula: {Matricula}");

            Console.WriteLine(sb.ToString());
        }
    }
}