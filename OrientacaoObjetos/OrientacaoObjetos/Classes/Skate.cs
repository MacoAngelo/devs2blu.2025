using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Classes
{
    internal class Skate : VeiculoTerrestre
    {
        public Skate(TipoVelocidade tipoVelocidade, int velocidade, int numeroRodas) : base(tipoVelocidade, velocidade, numeroRodas)
        {
        }

        public override void MostrarCaracteristicas()
        {
            base.MostrarCaracteristicas(); // Opcional - chama a base
            Console.WriteLine("Veículo do tipo Skate");
        }
    }
}
