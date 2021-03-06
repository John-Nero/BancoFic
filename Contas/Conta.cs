using System;

namespace Banco
{
    class Conta
    {
        private int Numero;
        private string Titular;
        protected double Saldo;

        public Conta() { }
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }



        public int getNumero()
        {
            return Numero;
        }
        public void setNumero(int numero)
        {
            Numero = numero;
        }

        public string getTitular()
        {
            return Titular;
        }
        public void setTitular(string titular)
        {
            Titular = titular;
        }

        public double getSaldo()
        {
            return Saldo;
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public virtual void Saque(double valor)
        {
            if (Saldo >= valor && valor > 0)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("SALDO INDISPONIVEL PARA OPERAÇÂO");
            }
        }
    }
}
