using System;
using System.Globalization;

namespace Banco
{
    class ContaCorrente : Conta
    {
        private double LimiteEmprestimo = 500;
        
        public ContaCorrente() { }
        public ContaCorrente(int numero, string titular) : base(numero, titular) { }
        public ContaCorrente(double limiteEmprestimo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                Deposito(valor);
                Console.WriteLine(" Saldo atualizado: ");
                Console.WriteLine($" Saldo: $ {getSaldo().ToString("F2", CultureInfo.InvariantCulture)} \n");
                LimiteEmprestimo -= valor;
            }
            else { Console.WriteLine("O SEU LIMITE DE EMPRESTIMO NÃO É SUFICIENTE PARA A OPERAÇÃO"); }
        }
        public override void Saque(double valor)
        {
            if (Saldo >= valor + 5 && valor > 0)
            {
                Saldo -= valor + 5;
            }else
            {
                Console.WriteLine("SALDO INDISPONIVEL PARA OPERAÇÂO");
            }
        
        }
    }
}
