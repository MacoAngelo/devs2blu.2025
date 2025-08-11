using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World.Console.Exercicios
{
    internal class DoWhileNumeroZero
    {
        public static void Executar()
        {
            bool sair = false;
            decimal saldoConta = 500;

            do
            {
                System.Console.Clear();
                System.Console.WriteLine("Banco +Devs2Blu, seja bem vindo!");
                System.Console.WriteLine("");
                System.Console.WriteLine("1 - Consultar saldo");
                System.Console.WriteLine("2 - Realizar depósito");
                System.Console.WriteLine("3 - Realizar saque");
                System.Console.WriteLine("4 - Sair");

                var entrada = System.Console.ReadLine();
                switch (entrada)
                {
                    case "1":
                        System.Console.WriteLine($"Saldo da conta: R$ {saldoConta}");
                        System.Console.WriteLine("Aperte qualquer tecla para voltar");
                        System.Console.ReadKey();
                        break;
                    case "2":
                        System.Console.Write("Informe o valor para depósito: ");
                        if (decimal.TryParse(System.Console.ReadLine(), out decimal valorDeposito)
                            && valorDeposito > 0)
                        {
                            saldoConta += valorDeposito;
                            System.Console.WriteLine("Depósito efetivado!");
                        }
                        else
                        {
                            System.Console.WriteLine("Depósito não efetivado!");
                        }

                        System.Console.WriteLine("Aperte qualquer tecla para voltar");
                        System.Console.ReadKey();
                        break;
                    case "3":
                        System.Console.Write("Informe o valor para saque: ");
                        if (decimal.TryParse(System.Console.ReadLine(), out decimal valorSaque)
                            && valorSaque > 0 && valorSaque <= saldoConta)
                        {
                            saldoConta -= valorSaque;
                            System.Console.WriteLine("Saque efetivado!");
                        }
                        else
                        {
                            System.Console.WriteLine("Saque não efetivado!");
                        }

                        System.Console.WriteLine("Aperte qualquer tecla para voltar");
                        System.Console.ReadKey();
                        break;
                    case "4":
                        sair = true;
                        break;
                    default:
                        System.Console.WriteLine("Opção inválida!");
                        Thread.Sleep(3000);
                        break;
                }

            } while (!sair);
        }
    }
}