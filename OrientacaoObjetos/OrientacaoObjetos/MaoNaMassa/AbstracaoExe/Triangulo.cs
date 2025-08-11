using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa.AbstracaoExe
{
    internal class Triangulo : Forma
    {
        private const int QUANTIDADE_FACES_TRIANGULO = 3;

        private double _TamanhoFace;

        public Triangulo(double tamanhoFace)
        {
            _TamanhoFace = tamanhoFace;
        }

        public override double CalcularPerimetro()
        {
            return _TamanhoFace * QUANTIDADE_FACES_TRIANGULO;
        }
    }
}
