using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio22
{
    internal class Conta : IOperacoes
    {
        private int numeroConta;
        private double saldo;

        public int NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public Conta(int numeroConta, double saldoInicial)
        {
            this.numeroConta = numeroConta;
            this.saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado. Novo saldo: {saldo}");
        }

        public void Levantar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Levantou {valor} realizado. Novo saldo: {saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        // Implementação da interface IOperacoes

        public bool InserirElemento(object x)
        {
            if (x is Conta)
            {
                return true;
            }

            return false;
        }

        public bool RemoverElemento(object x)
        {
            if (x is Conta)
            {
                return true;
            }

            return false;
        }

        public bool AtualizarElemento(object x)
        {
            if (x is Conta)
            {
                return true;
            }

            return false;
        }

        public object SelecionarElementos(Type typeValue)
        {
            if (typeValue == typeof(Conta))
            {
                List<Conta> listaContas = new List<Conta>();

            
                return listaContas;
            }

            return null;
        }
    }
}
