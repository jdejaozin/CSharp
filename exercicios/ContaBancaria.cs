using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios
{
    class ContaBancaria
    {
        private int _numConta;
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numConta, string Titular)
        {
            _numConta = numConta;
            this.Titular = Titular;
        }
        public ContaBancaria(int numConta, string Titular, double Saldo) : this(numConta, Titular)
        {
            this.Saldo = Saldo;
        }

        public void AlterarNome(string Titular)
        {
            this.Titular = Titular;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            Saldo -= valor;
            Saldo -= 5;
        }

        public override string ToString()
        {
            return "Dados da conta \nConta: " + _numConta +", Titular: " + Titular +
                ", Saldo: " + Saldo.ToString();
        }
    }
}
