using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class Conta
    {
        // Atributos
        private int numeroConta;
        private double saldo;

        // Propriedades
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

        // Construtores
        public Conta(int numeroConta, double saldoInicial)
        {
            this.numeroConta = numeroConta;
            this.saldo = saldoInicial;
        }

        // Métodos
        public virtual void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado. Novo saldo: {saldo}");
        }

        public virtual void Levantar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Levantou {valor} com sucesso. Novo saldo: {saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
    }
}
