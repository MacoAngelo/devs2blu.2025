using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espeiceneitor.Entidades
{
    public class Missao
    {
        private static int _Index = 1;

        public int Id { get; private set; }
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public string Detalhes { get; set; }
        public StatusMissao StatusMissao { get; set; }
        public DestinoMissao DestinoMissao { get; set; }

        public Missao(string nome, int duracao, DestinoMissao destino = DestinoMissao.Indefinido)
        {
            Id = _Index;
            Nome = nome;
            Duracao = duracao;
            DestinoMissao = destino;

            _Index++;
        }
    }
}