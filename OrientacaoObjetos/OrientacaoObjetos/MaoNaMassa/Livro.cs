using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa
{
    public class Livro
    {
        private int _PaginaAtual = 0;

        public string Nome { get; private set; }
        public string Autor { get; private set; }
        public int QuantidadePaginas { get; private set; }

        public Livro(string nome, string autor, int quantidadePaginas)
        {
            Nome = nome;
            Autor = autor;
            QuantidadePaginas = quantidadePaginas;
        }

        public int Ler()
        {
            _PaginaAtual++;
            Console.WriteLine($"Você leu a página de n° {_PaginaAtual}");

            return _PaginaAtual;
        }
    }
}
