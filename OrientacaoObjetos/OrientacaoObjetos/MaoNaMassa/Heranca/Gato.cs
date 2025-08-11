using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa.Heranca
{
    internal class Gato : Animal
    {
        private const string SOM_GATO = "MIAU MIAU";
        public override string Som => SOM_GATO;

        public Gato(string nome) : base(nome/*, SOM_GATO*/)
        {
        }


        // Solução com override
        //public override void EmitirSom()
        //{
        //    base.EmitirSom();
        //    Console.Write(SOM_GATO);
        //}
    }
}
