using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espeiceneitor.Entidades
{
    public class Astronauta
    {
        private static int _Index = 1;
        private static List<Astronauta> _Astronautas = new List<Astronauta>()
        {
            new Astronauta("Pelé", DateTime.MinValue, "Brasil"),
            new Astronauta("Maradona", DateTime.MinValue, "Argentina"),
            new Astronauta("Brian", DateTime.MinValue, "EUA"),
            new Astronauta("Joãozinho", DateTime.MinValue, "Brasil"),
        };

        public static List<Astronauta> Astronautas
        {
            get
            {
                var retorno = new List<Astronauta>();
                retorno.AddRange(_Astronautas);

                return retorno;
            }
        }

        public int Id { get; private set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Origem { get; set; }

        public Astronauta(string nome, DateTime dataNascimento, string origem)
        {
            Id = _Index;
            Nome = nome;
            DataNascimento = dataNascimento;
            Origem = origem;

            _Index++;
        }

        public void Create()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                throw new Exception("É impossível salvar um astronauta sem nome!");
            }

            _Astronautas.Add(this); // Adiciona na lista o proprio objeto
        }
    }
}