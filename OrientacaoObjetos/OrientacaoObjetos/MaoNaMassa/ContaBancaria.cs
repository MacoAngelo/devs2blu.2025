using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa
{
    public class ContaBancaria
    {
        public const int FATOR_PROVISIONAMENTO = 5;
        public const decimal VALOR_PADRAO_CHEQUE_ESPECIAL = 300m;
        public const decimal PERCENTUAL_RENDA_EMPRESTIMO = 0.5m;

        private static decimal _SaldoBanco = 100000;
        private static int _Contagem = 0;

        public static decimal SaldoBanco
        {
            get
            {
                return _SaldoBanco;
            }
        }
        public static int Contagem { get => _Contagem; }

        private bool _PossuiEmprestimo = false;

        private decimal Renda { get; set; }
        public string Titular { get; set; }
        private decimal Saldo { get; set; }
        private decimal SaldoChequeEspecial { get; set; }
        public TipoPessoa TipoConta { get; set; }

        public ContaBancaria(string titular, TipoPessoa tipo, decimal saldoChequeEspecial = VALOR_PADRAO_CHEQUE_ESPECIAL)
        {
            Titular = titular;

            SaldoChequeEspecial = saldoChequeEspecial;
            _Contagem++;
        }

        public ContaBancaria(string titular, decimal valor, TipoPessoa tipo, decimal saldoChequeEspecial = VALOR_PADRAO_CHEQUE_ESPECIAL)
        {
            Titular = titular;
            _Contagem++;

            Depositar(valor);

            //Saldo = valor;
            //_SaldoBanco += valor;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            _SaldoBanco += valor;
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
            _SaldoBanco -= valor;
        }

        public void DeclararRenda(decimal valor)
        {
            Renda = valor;
        }

        public void SolicitarEmprestimo(decimal valor, TipoCredito tipo)
        {
            if (_SaldoBanco >= (valor * FATOR_PROVISIONAMENTO))
            {
                if (_PossuiEmprestimo)
                {
                    Console.WriteLine("Identificamos que a conta já possui um empréstimo!");
                }
                else
                {
                    if (valor <= (Renda * PERCENTUAL_RENDA_EMPRESTIMO)
                        || tipo != TipoCredito.Pessoal)
                    {
                        Saldo += valor;
                        _PossuiEmprestimo = true;
                        Console.WriteLine("Empréstimo concedido!");
                    }
                    else
                    {
                        Console.WriteLine("Valor não aprovado devido a renda. Faça sua atualização cadastral.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Atualmente o banco não pode fornecer esse valor de empréstimo!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo da conta é: R$ {Saldo}");
        }
    }
}