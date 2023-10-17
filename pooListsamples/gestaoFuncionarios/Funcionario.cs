using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoFuncionarios
{
    internal class Funcionario
    {
        private string nome;
        private double salarioBase;
        private int idade;

        public Funcionario(string nome, double salarioBase, int idade)
        {
            this.nome = nome;
            this.salarioBase = salarioBase; 
            this.idade = idade; 
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrEmpty(this.nome))
                {
                    this.nome = nome;
                }
                else
                {
                    throw new ArgumentException("O nome do funcionário não pode ser vazio.");
                }
            }
        }

        public double SalarioBase
        {
            get { return salarioBase; }
            set
            {
                if (salarioBase >= 0)
                {
                    this.salarioBase = salarioBase;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("O salário base não pode ser negativo.");
                }
            }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (idade >= 0)
                {
                    this.idade = idade;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("A idade não pode ser negativa.");
                }
            }
        }

        public double CalcularBonus(double desempenho)
        {
            if (desempenho >= 0.0 && desempenho <= 1.0)
            {
                return SalarioBase * desempenho;
            }
            else
            {
                throw new ArgumentOutOfRangeException("O desempenho deve estar entre 0 e 1.");
            }
        }
    }
}
