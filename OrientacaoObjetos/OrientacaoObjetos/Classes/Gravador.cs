using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OrientacaoObjetos.Classes
{
    internal class Gravador : IDisposable
    {
        private string _NomeArquivo = $"{DateTime.Today.ToString("dd-MM-yyyy")}-Gravador.txt";

        public Gravador()
        {
            try
            {
                using FileStream fs = new FileStream(_NomeArquivo, FileMode.CreateNew);
            }
            catch (Exception erro)
            {
                throw new Exception($"Erro ao iniciar gravador. Mensagem: {erro.Message}");
            }
        }

        public static void Executar()
        {
            int opcao;
            using Gravador gravador = new Gravador();

            do
            {
                Console.Clear();
                Console.WriteLine("\n====== MENU ======");
                Console.WriteLine("1 - Escrever no arquivo");
                Console.WriteLine("2 - Ler o arquivo");
                Console.WriteLine("46 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        gravador.Escrever();
                        break;
                    case 2:
                        gravador.Ler();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 46);

            Console.Clear();
            Console.WriteLine("Programa encerrado!");
        }

        public void Dispose()
        {
            File.Delete(_NomeArquivo);
        }

        public void Escrever()
        {
            try
            {
                using (var arquivo = File.AppendText(_NomeArquivo))
                {
                    bool parar = false;
                    do
                    {
                        Console.Write("Informe o texto ($command:sair; para sair!): ");
                        var entrada = Console.ReadLine();

                        if (entrada == "$command:sair;")
                        {
                            parar = true;
                        }
                        else
                        {
                            arquivo.WriteLine(entrada);
                        }
                    } while (!parar);
                }
            }
            catch (Exception erro)
            {
                throw new Exception($"Erro ao registrar no gravador. Mensagem: {erro.Message}");
            }
        }

        public void Ler()
        {
            try
            {
                Console.Clear();
                Console.Write("Lendo arquivo:");
                Thread.Sleep(200);

                Console.Write("3... ");
                Thread.Sleep(500);

                Thread.Sleep(500);
                Console.Write("2... ");

                Thread.Sleep(500);
                Console.Write("1... ");

                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Carregando conteúdo...");
                string textoArquivo = File.ReadAllText(_NomeArquivo);
                Thread.Sleep(500);

                Console.Clear();
                Console.WriteLine(textoArquivo);
                Console.ReadKey();
            }
            catch (Exception erro)
            {
                throw new Exception($"Erro ao ler gravador. Mensagem: {erro.Message}");
            }
        }
    }
}