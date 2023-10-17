using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooListsamples
{
    internal class Curso
    {
        public string Nome { get; set; }
        private List<Aluno> alunosMatriculados = new List<Aluno>();

        public Curso(string nome)
        {
            Nome = nome;
        }

        public void AdicionarAluno(Aluno aluno)
        {
            alunosMatriculados.Add(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine("Alunos matriculados no curso "
                + Nome + ":");
            foreach (var aluno in alunosMatriculados)
            {
                Console.WriteLine("Nome: {0}, Matrícula: {1}"
                    , aluno.Nome, aluno.Matricula);
            }
        }
    }
}
