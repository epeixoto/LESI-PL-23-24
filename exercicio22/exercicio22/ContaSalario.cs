using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio22
{
    internal class ContaSalario : Conta
    {
        // Atributos específicos da ContaSalario
        private string empresa;

        // Propriedade específica da ContaSalario
        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        // Construtores
        public ContaSalario(int numeroConta, double saldoInicial, string empresa)
            : base(numeroConta, saldoInicial)
        {
            this.empresa = empresa;
        }

        // Método específico da ContaSalario
        public void PagarSalario(double valor)
        {
            Depositar(valor);
            Console.WriteLine($"Salário de {valor} pago pela empresa {empresa}. Novo saldo: {Saldo}");
        }
    }
}
