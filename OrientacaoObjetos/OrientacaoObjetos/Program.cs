

using OrientacaoObjetos.Classes;
using OrientacaoObjetos.MaoNaMassa.Heranca;
using OrientacaoObjetos.MaoNaMassa.Polimorfismo;
using OrientacaoObjetos.MaoNaMassa.Abstracao;
using OrientacaoObjetos.MaoNaMassa.AbstracaoExe;
using OrientacaoObjetos.Interfaces;

//var hb20 = new Carro();
//hb20.Marca = "Hyundai";
//hb20.Modelo = "HB20";
//hb20.Ano = 2012;

//var corsa = new Carro();
//corsa.Marca = "Chevrolett";
//corsa.Modelo = "Corsa";
//corsa.Ano = 1998;


//corsa.Acelerar(250);
//hb20.Acelerar(500);

//Animal doguinho = new Animal();

//doguinho.Nome = "Henrique";
//doguinho.NomeCientifico = "Dogux";
//doguinho.Idade = 2;

//for (int i = 0; i < 10; i++)
//{
//    doguinho.Comer();
//    Thread.Sleep(100);
//}

//Console.WriteLine($"Informe um novo nome para o {doguinho.Nome}");
//doguinho.Nome = Console.ReadLine();

//Console.WriteLine($"Agora ele se chama: {doguinho.Nome}");

//Livro livro = new Livro("Crepusculo", "Estefani Maier", 384);

//Livro livro2 = new Livro("Baita Livro", "Baita Autor", 8);



//var paginaAtual = 0;
//while (paginaAtual != livro.QuantidadePaginas)
//{
//    paginaAtual = livro.Ler();
//    Thread.Sleep(300);
//}

//Console.WriteLine("Você acabou de ler o livro");

//Sistema.DataInicialização = DateTime.Now;

//Console.WriteLine(Pessoa.Contagem);

//new Pessoa("Marco").Apresentar();
//Pessoa.ApresentarPessoa(new Pessoa("Joãozinho"));

//Console.WriteLine(Pessoa.Contagem);

//var aluno = new Aluno("Joãozinho", 18);


//aluno.CalcularIdadeEmMeses();
//aluno.ExibirInfo();
//aluno.ExibirInfoSb();

//var marco = new ContaBancaria("Marco", TipoPessoa.Fisica, 0);
//marco.DeclararRenda(1000);

//var joazinho = new ContaBancaria("Joãozinho", 10000, TipoPessoa.Fisica, 6000);
//joazinho.DeclararRenda(4000);

//var maria = new ContaBancaria("Maria", 6000, TipoPessoa.Fisica);
//maria.DeclararRenda(3000);

//joazinho.Sacar(5000);
//maria.Depositar(2000);
//marco.Depositar(250);

//Console.WriteLine(ContaBancaria.Contagem);
//Console.WriteLine(ContaBancaria.SaldoBanco);

//joazinho.SolicitarEmprestimo(53000);
//marco.SolicitarEmprestimo(5000);
//maria.SolicitarEmprestimo(500);
//maria.SolicitarEmprestimo(600 );

//var produto = new Produto("Camisa Azul", 12);
//var minhaCaminha = Produto.Comprar(produto, 10, out double troco);

//var cestaDeCompras = new List<Produto>() 
//{ 
//    new Produto("Coxinha", 6),
//    new Produto("Chocoleite", 8)
//};

//var minhasCompras = Produto.Comprar(cestaDeCompras, 13, out double troco2);

//Console.WriteLine($"Troco: {troco2}");
//if (minhasCompras != null)
//{
//    foreach (var produto in minhasCompras)
//    {
//        Console.WriteLine(produto.Nome);
//    }
//}


//Produto.FormatarPreco(produto.Preco);

//Produto.FormatarPreco(produto.Preco, true);

//int numero1 = 20;
//int numero2 = numero1;

//Console.WriteLine($"numero 1: {numero1}");
//Console.WriteLine($"numero 2: {numero2}");

//numero2++;

//Console.WriteLine($"numero 1: {numero1}");
//Console.WriteLine($"numero 2: {numero2}");

//var thiago = new Pessoa("Thiago", 43);
//Console.WriteLine($"Nome: {thiago.Nome}. Idade: {thiago.Idade}.");

//Sistema.TesteDeReferencia(thiago);

//Console.WriteLine($"Nome: {thiago.Nome}. Idade: {thiago.Idade}.");


//var numero = 25;
//Console.WriteLine(numero);
//Sistema.TesteDeReferencia(ref numero);
//Console.WriteLine(numero);


//var nathan = thiago;
//nathan.Nome = "Nathan";
//nathan.Idade = 23;




//Console.WriteLine($"Nome: {nathan.Nome}. Idade: {nathan.Idade}.");


//Console.WriteLine($"");


//List<int> inteiros = new List<int> { 1, 2, 3, 4, 5, 6 };
//inteiros = inteiros.Select(i => ++i).ToList();

//foreach (int i in inteiros)
//{
//    Console.WriteLine(i);
//}

//List<Veiculo> veiculos = new List<Veiculo>()
//{
//    new Veiculo(TipoVelocidade.Km, 500),
//    new VeiculoTerrestre(TipoVelocidade.Km, 50, 4),
//    new Moto(TipoVelocidade.Km, 120, 2),
//    new Skate(TipoVelocidade.Km, 10, 4),
//};

//foreach (var veiculo in veiculos)
//{
//    // Curiosidade: Como fazer método da classe filha funcionar sem o virtual utilizando lista genérica.
//    //if (veiculo is Skate)
//    //{
//    //    (veiculo as Skate).MostrarCaracteristicas();
//    //}
//    //else
//    //{
//    //    veiculo.MostrarCaracteristicas();
//    //}

//    veiculo.MostrarCaracteristicas();
//}

//var animais = new List<Animal>() {
//    //new Animal("Bolinha"),
//    new Gato("Fred"),
//    new Cachorro("Kika"),
//};

//foreach (var animal in animais)
//{
//    animal.EmitirSom();
//    Console.WriteLine(animal.ToString());
//    Console.WriteLine("");
//}

//InstrumentoMusical[] instrumentoMusicals = new InstrumentoMusical[3];

//instrumentoMusicals[0] = new Violao();
//instrumentoMusicals[1] = new Piano();
//instrumentoMusicals[2] = new Tambor();

//for (int index = 0; index < instrumentoMusicals.Length; index++)
//{
//    instrumentoMusicals[index].Tocar();
//}

//var formas = new List<FormaGeometrica>()
//{
//    //new FormaGeometrica(), -> Não é possível instanciar diretamente a classe devido ela ser abstract.
//    new Circulo(5),
//};

//foreach (var forma in formas)
//{
//    Console.WriteLine(forma.ToString());
//}

//var formas = new List<Forma>() {
//    new Triangulo(20),
//    new Retangulo(20, 40)
//};

//foreach (var forma in formas)
//{
//    Console.WriteLine($"O perímetro do {forma.GetType()} é {forma.CalcularPerimetro()}");
//}

//List<IMotorizado> motorizados = new List<IMotorizado>();

//motorizados.Add(new Carro());

//foreach (var o in motorizados)
//{
//    o.Ligar();
//}

//Gravador.Executar();
//new UsuarioSistema().Logar("pele", "bolinha");

var carros = new List<Carro>() { 
    new Carro("Hyundai", "HB20", "Preta", 2014),
    new Carro("Hyundai", "HB20", "Vermelho", 2022),
    new Carro("Hyundai", "HB20", "Preta", 2036),
    new Carro("Hyundai", "HB20", "Preta", 1998),
    new Carro("Hyundai", "HB20", "Branco", 2008),
    new Carro("Hyundai", "HB20", "Preta", 2014),
    new Carro("Hyundai", "HB20", "Prata", 2011),
    new Carro("Hyundai", "HB20", "Preta", 2017),
    new Carro("Hyundai", "HB20", "Preta", 2013),
};

// var selecionados = carros.Where(carro => carro.Cor != "Preta");
//var selecionados = carros.OrderBy(i => i.Ano)
    //.Where(i => i.Cor != "Preta");

foreach (var car in carros)
{
    Console.WriteLine($"{car.ID} - {car.Modelo} - {car.Ano}");
}

Console.WriteLine("Selecione um carro :)");
var idCarro = int.Parse(Console.ReadLine());

var carroCarregado = carros.Any(i => i.ID == idCarro) ? carros.First(i => i.ID == idCarro) : null;
Console.WriteLine($"Você selecionou o seguinte carro: {carroCarregado?.ID} - {carroCarregado?.Modelo} - {carroCarregado?.Ano}");


Console.ReadKey();