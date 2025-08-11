namespace Espeiceneitor.Entidades
{
    public class Lancamento
    {
        public Missao Missao { get; private set; }
        public List<Astronauta> Astronautas { get; private set; }

        public Lancamento(Missao missao, List<Astronauta> astronautas)
        {
            Missao = missao;
            Astronautas = astronautas;
        }
    }
}