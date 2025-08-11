//Console.WriteLine("Bolinha");

/* ATALHOS LEGAIS - Comentário de múltiplas linhas
 * Comentar código selecionado: CTRL + K + C
 * Descomentar código selecionado: CTRL + K + U
*/

// Comentário de linha única

//const string PRIMEIRA_CONSTANTE = "MARCO ANTONIO ANGELO";

//// var nomeInferenciaTeste; -> Não funciona por não ter um valor.
//var nomeInferencia = "Marco";

//string nomeMeio = "Antonio";

//string sobrenome;
//sobrenome = "Angelo";

//// Concatenação comum
//Console.WriteLine(nomeInferencia + " " + nomeMeio + " " + sobrenome);


// Mão na massa:
//Console.WriteLine("Olá, meu nome é João. Tenho 18 anos!");

//Console.WriteLine("Você poderia me informar o seu nome?");
//string nome = Console.ReadLine();

//Console.WriteLine("Agora você poderia me informar seu usuário?");
//string usuario = Console.ReadLine();

//Console.WriteLine("Prazer em te conhecer " + nome + "(" + usuario + ")!");


// Uso de tipos de dados

//bool valorBooleano;
//valorBooleano = true;
//Console.WriteLine(valorBooleano);

//valorBooleano = false;
//Console.WriteLine(valorBooleano);

//char valorChar;
//valorChar = 'M';
//Console.WriteLine(valorChar);

//string nome = "Marco";
//string sobrenome = "Angelo";
//Console.WriteLine(nome);
//Console.WriteLine("O primeiro caracter do seu nome é " + nome[0]);
//Console.WriteLine("O segundo caracter do seu nome é " + nome[1]);
//Console.WriteLine("O terceiro caracter do seu nome é " + nome[2]);

//Console.WriteLine();

//// Concatenação: Tipo 1
//Console.WriteLine("Concatenação simples: " + nome + " " + sobrenome);

//// Concatenação: Tipo 2
//string nomeCompleto = string.Format("Concatenação com template: {0} {1}", nome, sobrenome);
//Console.WriteLine(nomeCompleto);

//// Isso só funciona pq o WriteLine tem um comportamento padrão.
////Console.WriteLine("Concatenação com template: {0} {1}", nome, sobrenome);

//// Interpolação:
//string nomeCompletasso = $"Interpolação: {nome} {sobrenome}";
//Console.WriteLine(nomeCompletasso);

//var sb = new StringBuilder();
//sb.AppendLine("Dados de usuário");
//sb.AppendLine($"Nome: {nome}");
//sb.AppendLine($"Sobrenome: {sobrenome}");
//sb.AppendLine("Natural de: Gaspar");

//Console.WriteLine(sb.ToString());

//string a = null;
//string b = null;

//a = "Marco";
//Console.WriteLine(a.ToUpper());

// Isso dá erro. Isso ocorre devido ao objeto b estar nulo e tentarmos utilizar um comportamento do string.
//Console.WriteLine(b.ToUpper());

//Console.WriteLine("Qual dia você nasceu?");
//var diaTexto = Console.ReadLine();

//Console.WriteLine("Qual o mês que você nasceu?");
//var mesTexto = Console.ReadLine();

//Console.WriteLine("Qual o ano que você nasceu?");
//var anoTexto = Console.ReadLine();

//// Converte os valores
//int dia = int.Parse(diaTexto);
//int mes = int.Parse(mesTexto);
//int ano = int.Parse(anoTexto);

////Console.WriteLine($"Data de nascimento: {dia}/{mes}/{ano}");
//var data = new DateTime(ano, mes, dia);
//Console.WriteLine(data.ToString("dd/MM/yyyy"));


//Console.WriteLine($"5 +  7 = {5 + 7}");
//Console.WriteLine($"5 -  7 = {5 - 7}");
//Console.WriteLine($"2 * 10 = {2 * 10}");
//Console.WriteLine($"10 / 3 = {10.0 / 3.0}"); // Usei o .0 para considerar o ponto flutuante
//Console.WriteLine($"10 % 3 = {10 % 3}");


//var b = 10;
//Console.WriteLine($"b = {b}");

//b = 20;
//Console.WriteLine($"b = {b}");

//b += 10;
//Console.WriteLine($"b = {b}");

//b -= 5;
//Console.WriteLine($"b = {b}");

//b *= 10;
//Console.WriteLine($"b = {b}");

//b /= 2;
//Console.WriteLine($"b = {b}");

//b %= 2;
//Console.WriteLine($"b = {b}");

//b++;
//Console.WriteLine($"b = {b}");

//b--;
//Console.WriteLine($"b = {b}");

//var resultado = 10.3 / 6.36;
//Console.WriteLine($"Resultado da divisão: {resultado}");

//var resultadoBonito = resultado.ToString("F2");
//Console.WriteLine($"Resultado da divisão bonito: {resultadoBonito}");

//var numeroInteiro = 23;
//Console.WriteLine($"{++numeroInteiro} - Usuário");
//Console.WriteLine($"{numeroInteiro.ToString("D5")} - Usuário");

//Console.WriteLine($"1 == 1 = {1 == 1}");
//Console.WriteLine($"1 != 1 = {1 != 1}");

//Console.WriteLine($"1 > 1 = {1 > 1}");
//Console.WriteLine($"1 >= 1 = {1 >= 1}");

//Console.WriteLine($"1 < 1 = {1 < 1}");
//Console.WriteLine($"1 <= 1 = {1 <= 1}");

//int media = 10;
//int presenca = 69;
//Console.WriteLine($"Passou: {media >= 7 && presenca >= 75}");

//bool tenhoBicicleta = true;
//bool tenhoPasse = true;
//bool tenhoCarro = false;

//Console.WriteLine($"Vou pra aula: {tenhoBicicleta || tenhoPasse || tenhoCarro}");

//bool tahQuente = false;
//Console.WriteLine($"Vamo empurrar o chevete? {!tahQuente}");

//string resultadoTernario = tahQuente ? "vai pegar" : "não vai pegar";
//string saida = $"Hoje o chevete {resultadoTernario}";
//if (tahQuente)
//{
//    saida += "vai pegar";
//}
//else
//{
//    saida += "não vai pegar";
//}

//Console.WriteLine(saida);

//Console.WriteLine("Me informe a sua idade :)");
//var idade = int.Parse(Console.ReadLine());
//if (idade > 50)
//{
//    Console.WriteLine("Você é muito experiente!");
//}
//else if (idade >= 18)
//{
//    Console.WriteLine("Você é maior de idade!");
//}
//else
//{
//    Console.WriteLine("Você é menor de idade!");
//}


// Mão na massa - 01
//Hello.World.Console.MaosNaMassa.PraticaIfElse.Executar();

//Console.WriteLine("Informe uma letra");
//char letra = Console.ReadLine()[0];

//switch (letra)
//{
//    case 'A':
//    case 'B':
//        Console.WriteLine("Essa letra, é a letra A ou a letra B!");
//        break;
//    case 'F':
//        Console.WriteLine("Essa letra, é a letra F!");
//        break;
//    default:
//        Console.WriteLine("Essa letra eu não conheço!");
//        break;
//}

//Hello.World.Console.MaosNaMassa.PraticaSwitch.Executar();

//string[] nomes = new string[5];
//var nomesPreenchidos = new[] { "Marco", "Ana", "João" };

//nomes[0] = "Marco";
//nomes[4] = "Ana";

//Console.WriteLine(nomes.ToString()); // Vai apresentar System.String[] pq o Array não tem uma conversão customizada para string
//Console.WriteLine("Final");

//Hello.World.Console.MaosNaMassa.PraticaArray.Executar();

//List<string> pessoas = new List<string>();

//pessoas.Add("Marco");
//pessoas.Add("Maria");
//pessoas.Add("Maria");
//pessoas.Add("Marco");

//pessoas.Remove("Maria");

//foreach(string pessoa in pessoas)
//{
//    Console.WriteLine(pessoa);
//}

//Console.WriteLine("=-=-=-=-=-=-=-=-=");


//List<string> pessoasInicializadas = new List<string> { "Marco", "Pedro", "João"};

//pessoasInicializadas.Add("Maria");

//foreach (string pessoa in pessoasInicializadas)
//{
//    Console.WriteLine(pessoa);
//}

//Hello.World.Console.MaosNaMassa.PraticaLista.Executar();

//var alunos = new string[] { "Maria", "João", "Pedro"};
//for (int i = 0; i < alunos.Length; i++)
//{
//    Console.WriteLine(alunos[i]);
//}

//Hello.World.Console.MaosNaMassa.PraticaFor.Executar();

//var nomes = new List<string>();

//Console.WriteLine("Informe um nome ou SAIR para finalizar");
//string entrada = Console.ReadLine();

//while (entrada != "SAIR")
//{
//    nomes.Add(entrada);

//    Console.WriteLine("Informe um nome ou SAIR para finalizar");
//    entrada = Console.ReadLine();
//}

//foreach(var nome in nomes)
//{
//    Console.WriteLine(nome);
//}

//Hello.World.Console.MaosNaMassa.PraticaWhile.Executar();

//Console.WriteLine("Me informe um número");
//var entrada = Console.ReadLine();

//var converteu = double.TryParse(entrada, out double resultado); // Nessa linha eu crio a var resultado
//converteu = double.TryParse(entrada, out resultado); // Nessa linha eu reaproveito a var resultado

//Console.WriteLine($"Converteu: {converteu}");
//Console.WriteLine($"Valor: {resultado}");

//Console.ReadLine();

//string aluno;
//bool continua = false;
//var alunos = new List<string>();

//do
//{
//    Console.WriteLine("Informe o nome do aluno ou ok para sair");
//    aluno = Console.ReadLine();

//    if (aluno.ToLower() != "ok")
//    {
//        alunos.Add(aluno);
//        continua = true;
//    }
//    else
//    {
//        continua = false;
//    }
//} while (continua);

//foreach (var item in alunos)
//{
//    Console.WriteLine(item);
//}

//Hello.World.Console.MaosNaMassa.PraticaDoWhile.Executar();

//List<string> carros = new List<string>() { "Uno", "Celta", "Corsa", "Fusca" };

//foreach (var carro in carros)
//{
//    Console.WriteLine(carro);
//}


//string saida = "O número informado é ";
//string resultado = "";

//Console.WriteLine("Informe um número inteiro :)");
//var numero = int.Parse(Console.ReadLine());

//resultado = numero == 0 ? "ZERO" :
//    numero > 0 ? "POSITIVO" : "NEGATIVO";

//Console.WriteLine($"{saida}{resultado}");


Hello.World.Console.Exercicios.SwitchNumeroZero.Executar();

decimal numero = 6.16m;
Console.WriteLine((int)numero);