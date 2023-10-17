using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listHeranca
{
    internal class Aluno : Pessoa
    {
        public int Matricula { get; set; }

        public Aluno(string nome, int idade, int matricula)
            : base(nome, idade)
        {
            Matricula = matricula;
        }

        public override void Mostrar()
        {
            Console.WriteLine("Olá, o meu nome é {0}, tenho {1} anos e a minha matrícula é {2}.",
                Nome, Idade, Matricula);
        }
    }
}
