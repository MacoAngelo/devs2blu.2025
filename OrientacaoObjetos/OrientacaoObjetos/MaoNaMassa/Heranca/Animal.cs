using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa.Heranca
{
    internal abstract class Animal
    {
        //private const string SOM_PADRAO = "PUFF";

        public string Nome { get; set; }
        public abstract string Som { get; }

        public Animal(string nome/*, string som = SOM_PADRAO*/)
        {
            Nome = nome;
            //Som = som;
        }

        public virtual void EmitirSom()
        {
            Console.Write($"O {Nome} está tentando emitir um som: ");

            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");

            Console.Write($" {Som}");
        }

        // Solução com override
        //public virtual void EmitirSom()
        //{
        //    Console.Write($"O {Nome} está tentando emitir um som: ");

        //    Thread.Sleep(800);
        //    Console.Write(".");
        //    Thread.Sleep(800);
        //    Console.Write(".");
        //    Thread.Sleep(800);
        //    Console.Write(".");
        //}
    }
}