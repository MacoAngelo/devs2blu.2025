using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa.Polimorfismo
{
    internal class InstrumentoMusical
    {
        public virtual void Tocar()
        {
            Console.WriteLine("Ba dum tix!");
        }
    }
}