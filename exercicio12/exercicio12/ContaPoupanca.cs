using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class ContaPoupanca : Conta
    {
        // Atributos específicos da ContaPoupanca
        private double taxaJuros;

        // Propriedade específica da ContaPoupanca
        public double TaxaJuros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }

        // Construtores
        public ContaPoupanca(int numeroConta, double saldoInicial, double taxaJuros)
            : base(numeroConta, saldoInicial)
        {
            this.taxaJuros = taxaJuros;
        }

        // Método específico da ContaPoupanca
        public void CalcularJuros()
        {
            double juros = Saldo * taxaJuros;
            Depositar(juros);
            Console.WriteLine($"Juros de {juros} calculados e depositados. Novo saldo: {Saldo}");
        }
    }
}
