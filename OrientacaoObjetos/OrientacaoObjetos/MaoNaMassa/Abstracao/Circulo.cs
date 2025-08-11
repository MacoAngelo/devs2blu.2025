using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa.Abstracao
{
    internal class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
}