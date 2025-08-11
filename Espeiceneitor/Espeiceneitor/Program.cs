using Espeiceneitor;
using Espeiceneitor.Utils;

// Escopo/Contexto responsável por executar o código
try
{
	ProgramaEspacial.ExecutarProgramaEspacial();
}
// Escopo/Contexto responsável por tratar exceções
catch (Exception erro) // Variável responsável por armazenar a exceção que ocorreu
{
	string mensagem = $"Ocorreu um erro ao executar o programa espacial.\nErro encontrado: {erro.Message}";
	Console.WriteLine(mensagem);


	ConsoleUtil.AguardarTecla();
}
