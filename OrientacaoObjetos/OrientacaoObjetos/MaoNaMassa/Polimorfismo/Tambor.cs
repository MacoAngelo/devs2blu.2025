using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa.Polimorfismo
{
    internal class Tambor : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("Pum");
        }
    }
}