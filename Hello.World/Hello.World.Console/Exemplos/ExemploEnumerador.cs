using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.Exemplos
{
    public enum TipoPessoa
    {
        Fisica,
        Juridica,
        Especial
    }

    internal class ExemploEnumerador
    {
        public static void Executar()
        {
            var tipoPessoa = TipoPessoa.Fisica;

            switch (tipoPessoa)
            {
                case TipoPessoa.Fisica:
                    break;
                case TipoPessoa.Juridica:
                    break;
                case TipoPessoa.Especial:
                    break;
            }
        }
    }
}