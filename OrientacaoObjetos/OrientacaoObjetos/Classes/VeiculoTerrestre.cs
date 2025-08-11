using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Classes
{
    internal class VeiculoTerrestre : Veiculo
    {
        public int NumeroRodas { get; set; }

        //                                                                       Chama o contrutor da classe base/mãe
        public VeiculoTerrestre(TipoVelocidade tipoVelocidade, int velocidade, int numeroRodas) : base(tipoVelocidade, velocidade)
        {
            NumeroRodas = numeroRodas;
        }

        public void Buzinar()
        {
            Console.WriteLine("Biiiiii!");
        }

        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Dados do veículo terrestre: \n");

            base.MostrarCaracteristicas(); // Opcional - chama a base
            Console.WriteLine($"Número de rodas: {NumeroRodas}");
        }
    }
}
