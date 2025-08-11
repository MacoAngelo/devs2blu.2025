using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Classes
{
    internal class Veiculo
    {
        public TipoVelocidade TipoVelocidade { get; set; }
        public int Velocidade { get; set; }

        public Veiculo(TipoVelocidade tipoVelocidade, int velocidade)
        {
            TipoVelocidade = tipoVelocidade;
            Velocidade = velocidade;
        }

        public void Mover()
        {
            Console.WriteLine($"O veículo está se movendo a {Velocidade} {TipoVelocidade.ToString()}");
        }

        public virtual void MostrarCaracteristicas()
        {
            Console.WriteLine($"Unidade de velocidade: {TipoVelocidade}");
            Console.WriteLine($"Velocidade de locomoção: {Velocidade}");
        }
    }
}