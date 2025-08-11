using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Classes
{
    internal class Sistema
    {
        public static DateTime DataInicialização { get; set; }

        public static int LerInteiro(string mensagem)
        {
            Console.WriteLine(mensagem);
            var entrada = Console.ReadLine();
            int.TryParse(entrada, out int resultado);

            return resultado;
        }

        public static char LerChar(string mensagem)
        {
            Console.WriteLine(mensagem);
            var entrada = Console.ReadLine();

            return entrada == null ? ' ' : entrada[0];
        }

        public static void TesteDeReferencia(Pessoa pessoa)
        {
            pessoa.Idade++;
        }

        public static void TesteDeReferencia(ref int bolinha)
        {
            bolinha++;
            Console.WriteLine(bolinha);
        }
    }
}
