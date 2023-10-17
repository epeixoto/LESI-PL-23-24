using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooListsamples
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

    }
}
