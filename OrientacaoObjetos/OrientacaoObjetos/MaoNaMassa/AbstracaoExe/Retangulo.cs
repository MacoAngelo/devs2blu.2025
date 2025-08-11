using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa.AbstracaoExe
{
    internal class Retangulo : Forma
    {
        private const int FATOR_MULTIPLICACAO_RETANGULO = 2;

        private double _Altura;
        private double _Base;

        public Retangulo(double altura, double basee)
        {
            _Altura = altura;
            _Base = basee;
        }

        public override double CalcularPerimetro()
        {
            return (_Altura + _Base) * FATOR_MULTIPLICACAO_RETANGULO;
        }
    }
}
