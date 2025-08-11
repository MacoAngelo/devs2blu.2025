using Espeiceneitor.Entidades;
using Espeiceneitor.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espeiceneitor
{
    public class ProgramaEspacial
    {
        

        private static List<Missao> _Missoes = new List<Missao>()
        {
            new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),
                        new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),
                        new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),
                        new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),
                        new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),
                        new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),

        };

        private static List<Lancamento> _Lancamentos = new List<Lancamento>();

        public static void ExecutarProgramaEspacial()
        {
            Console.WriteLine("Bem-vindo ao Espeiceneitor!");
            Console.WriteLine("1 - Cadastrar Astronautas");
            Console.WriteLine("2 - Listar Astronautas");
            Console.WriteLine("3 - Cadastrar Missões");
            Console.WriteLine("4 - Listar Missões");
            Console.WriteLine("5 - Realizar Lançamento");
            Console.WriteLine("6 - Listar Lançamentos");
            Console.WriteLine("7 - Relatório de missão");

            try
            {
                var entrada = Console.ReadLine();
                switch (entrada)
                {
                    case "1":
                        CadastroAstronautas();
                        break;
                    case "2":
                        ListagemAstronautas();
                        ConsoleUtil.AguardarTecla();
                        break;
                    case "3":
                        CadastroMissao();
                        break;
                    case "4":
                        ListagemMissoes();
                        ConsoleUtil.AguardarTecla();
                        break;
                    case "5":
                        RealizarLancamento();
                        break;
                    case "6":
                        ListagemLancamentos();
                        ConsoleUtil.AguardarTecla();
                        break;
                    case "7":
                        AtualizarMissao();
                        ConsoleUtil.AguardarTecla();
                        break;
                }
            }
            catch (Exception erro)
            {
                Console.Clear();
                Console.WriteLine($"Ocorreu um erro ao executar operação!\n Mensagem: {erro.Message}");
                Console.WriteLine("Aperte qualquer tecla para voltar para o menu...");
                Console.ReadKey();
            }

            Console.Clear();
            ExecutarProgramaEspacial();
        }

        private static void CadastroAstronautas()
        {
            bool continuar = false;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("CADASTRO DE ASTRONAUTA - ESC PARA SAIR!");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        continuar = false;
                        //break; -> Parar o looping
                    }
                    else
                    {
                        string nome = ConsoleUtil.Interagir("Informe o nome do astronauta: ");
                        DateTime dataNascimento = ConsoleUtil.InteragirDateTime("Informe a data de nascimento do astronauta: ");
                        string origem = ConsoleUtil.Interagir("Informe o país de origem do astronauta: ");

                        var astronauta = new Astronauta(nome, dataNascimento, origem);
                        astronauta.Create();

                        continuar = true;
                    }
                }
                catch (Exception erro)
                {
                    throw new Exception($"Ocorreu um erro na rotina de cadastro de astronauta. Mensagem: {erro.Message}");
                }
            } while (continuar);
        }

        private static void ListagemAstronautas()
        {
            Console.Clear();
            Console.WriteLine("Lista de astronautas");
            foreach (var item in Astronauta.Astronautas)
            {
                Console.WriteLine($"[{item.Id}] - {item.Nome}, {item.Origem}");
            }
        }

        private static void CadastroMissao()
        {
            // NÃO UTILIZAR DESSA FORMA - PODE OCASIONAR LOOPING
            do
            {
                Console.Clear();
                Console.WriteLine("CADASTRO DE MISSÃO - ESC PARA SAIR!");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break; // QUEBRA O LOOPING
                }
                else
                {
                    var nome = ConsoleUtil.Interagir("Informe o nome da missão: ");
                    var duracao = ConsoleUtil.InteragirInt("Informe a duração em dias: ");
                    var destino = ConsoleUtil.InteragirInt("Informe o destino da missão (1 - Lua, 2 - Marte): ");

                    var missao = new Missao(nome, duracao, (DestinoMissao)destino);
                    _Missoes.Add(missao);
                }
            } while (true);
        }

        private static void ListagemMissoes()
        {
            Console.Clear();
            Console.WriteLine("Lista de missões");
            foreach (var missao in _Missoes)
            {
                Console.WriteLine($"[{missao.Id}] - {missao.Nome}, {missao.Duracao} - {missao.DestinoMissao} - [{missao.StatusMissao}]");
            }
        }

        private static Missao BuscarMissao(int index)
        {
            Missao missaoSelecionada = null;
            foreach (var missao in _Missoes)
            {
                //Console.WriteLine("Processando...");
                if (missao.Id == index)
                {
                    missaoSelecionada = missao;
                    break; // quebra do looping
                }
            }

            //if (missaoSelecionada == null)
            //{
            //    Console.WriteLine("Missão não encontrada!");
            //}
            //else
            //{
            //    Console.WriteLine("Missão encontrada!");
            //}

            return missaoSelecionada;
        }

        private static Astronauta BuscarAstronauta(int index)
        {
            Astronauta astronautaSelecionado = null;
            foreach (var astronauta in Astronauta.Astronautas)
            {
                if (astronauta.Id == index)
                {
                    astronautaSelecionado = astronauta;
                    break;
                }
            }

            return astronautaSelecionado;
        }

        private static void RealizarLancamento()
        {
            // Selecionar a missão
            ListagemMissoes();
            int idMissao = ConsoleUtil.InteragirInt("Informe o ID da missão: ");
            Missao missao = BuscarMissao(idMissao);

            // Selecionar os astronautas
            bool continuar = false;
            List<Astronauta> astronautasLancamento = new List<Astronauta>();
            do
            {
                Console.Clear();
                Console.WriteLine("Adição de astronautas - 0 PARA FINALIZAR!");


                ListagemAstronautas();
                int idAstronauta = ConsoleUtil.InteragirInt("Informe o ID do astronauta: ");
                if (idAstronauta == 0)
                {
                    continuar = false;
                }
                else
                {
                    Astronauta astronauta = BuscarAstronauta(idAstronauta);

                    astronautasLancamento.Add(astronauta);
                    continuar = true;
                }
            } while (continuar);

            var lancamento = new Lancamento(missao, astronautasLancamento);
            lancamento.Missao.StatusMissao = StatusMissao.EmLancamento;

            Console.WriteLine("Realizado lançamento!");
            ConsoleUtil.AguardarTecla();

            _Lancamentos.Add(lancamento);
        }

        private static void ListagemLancamentos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Lançamentos");
            foreach (var lancamento in _Lancamentos)
            {
                Console.WriteLine($"Missão do lançamento: {lancamento.Missao.Nome}");
                Console.WriteLine($"Destino: {lancamento.Missao.DestinoMissao}");
                Console.WriteLine($"");
                Console.WriteLine($"Astronautas");
                foreach(var astronauta in lancamento.Astronautas)
                {
                    Console.WriteLine($"[{astronauta.Id}] {astronauta.Nome}");
                }
            }
        }

        private static void AtualizarMissao()
        {
            ListagemMissoes();
            int idMissao = ConsoleUtil.InteragirInt("Informe o ID da missão: ");
            Missao missao = BuscarMissao(idMissao);

            int status = ConsoleUtil.InteragirInt("Informe o status da missão (1- Sucesso, 2 - Falha): ");
            string detalhes = ConsoleUtil.Interagir("Informe os detalhes da missão: ");

            missao.StatusMissao = (StatusMissao)status;
            missao.Detalhes = detalhes;

            Console.WriteLine("Missão atualizada!");
        }
    }
}