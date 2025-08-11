using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        private int QuantidadeEstoque { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public static Produto Comprar(Produto produto, double valorPagamento, out double troco)
        {
            if (produto.Preco > valorPagamento)
            {
                Console.WriteLine("Você não deu dinheiro o suficiente!");
            }
            else
            {
                Console.WriteLine("Produto comprado!");
            }

            troco = valorPagamento - produto.Preco;
            return produto;
        }

        public static List<Produto> Comprar(List<Produto> produtos, double valorPagamento, out double troco)
        {
            double total = 0;

            foreach(var produto in produtos)
            {
                total += produto.Preco;
            }

            troco = valorPagamento - total;
            if (troco < 0)
            {
                Console.WriteLine("Não é possível realizar a compra, pegue seu troco!");
                troco = valorPagamento;
                return null;
            }
            else
            {
                Console.WriteLine("Compra realizada, retire seus produtos!");
                return produtos;
            }
        }

        public static void FormatarPreco(double preco)
        {
            FormatarPreco(preco, false);
        }
        public static void FormatarPreco(double preco, bool internacional)
        {
            Console.WriteLine($"{preco.ToString("C", CultureInfo.CreateSpecificCulture(internacional ? "en-US" : "pt-BR"))}");
        }

        public void AtualizarEstoque(int quantidade)
        {
            QuantidadeEstoque = quantidade;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Relatório do produto");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: R$ {Preco}");
            Console.WriteLine($"Quantidade estoque: {QuantidadeEstoque}");
        }
    }
}
