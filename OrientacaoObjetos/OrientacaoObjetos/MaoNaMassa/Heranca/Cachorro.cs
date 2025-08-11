using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa.Heranca
{
    internal class Cachorro : Animal
    {
        private const string SOM_CACHORRO = "AU AU";
        public override string Som => SOM_CACHORRO;
        public Cachorro(string nome) : base(nome/*, SOM_CACHORRO*/)
        {
        }

        public override string ToString()
        {
            return Nome;
        }

        // Solução com override
        //public override void EmitirSom()
        //{
        //    base.EmitirSom();
        //    Console.Write(SOM_CACHORRO);
        //}
    }
}
