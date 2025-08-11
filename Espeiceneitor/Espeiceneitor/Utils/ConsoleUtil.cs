using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espeiceneitor.Utils
{
    public class ConsoleUtil
    {
        public static void AguardarTecla()
        {
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public static string Interagir(string mensagem)
        {
            Console.Write(mensagem);
            return Console.ReadLine();
        }

        public static int InteragirInt(string mensagem)
        {
            int.TryParse(Interagir(mensagem), out int retorno);

            return retorno;
        }

        public static DateTime InteragirDateTime(string mensagem)
        {
            DateTime.TryParse(Interagir(mensagem), out DateTime retorno);

            return retorno;
        }
    }
}
