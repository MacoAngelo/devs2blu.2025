using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Classes
{
    public class Pessoa
    {
        private static int _Contagem = 0;
        public static int Contagem { get => _Contagem; }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            _Contagem++;
        }

        public Pessoa(string nome, int idade)
        {
            _Contagem++;

            Nome = nome;
            Idade = idade;
        }

        public static Pessoa GerarPessoaComBase(Pessoa pessoaBase)
        {
            return new Pessoa()
            {
                Nome = pessoaBase.Nome,
                Idade = pessoaBase.Idade,
            };
        }

        public static void ResetarContagem()
        {
            _Contagem = 0;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}!");
        }

        public static void ApresentarPessoa(Pessoa pessoa)
        {
            Console.WriteLine($"Olá meu nome é {pessoa.Nome}!");
        }
    }
}