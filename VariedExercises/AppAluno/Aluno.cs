using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herance
{
    internal class Aluno : Pessoa
    {
        public string Matricula {  get; set; }
        public string Curso { get; set; }

        public Aluno(string nome, int idade, string matricula,
            string curso) : base (nome, idade) { 
            Matricula = matricula;
             Curso = curso;
        }

        public void Estudar() {
            Console.WriteLine("O {0} está a estudar a UC {1} " +
                "e tem a matricula {2}",
                Nome, Curso, Matricula);
        }
    }
}
