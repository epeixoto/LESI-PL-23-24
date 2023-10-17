using exemplo_classe_protected;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApp
{
    internal class Aluno2 : Pessoa
    {
        // Atributo específico de Aluno
        private string matricula;

        // Construtor
        public Aluno2(string nome, int idade, string matricula)
            : base(nome, idade) // construtor da classe base: Pessoa
        {
            this.matricula = matricula;
        }

        // Método público para mostrar informações de Aluno
        public void MostrarMatricula()
        {
            Console.WriteLine("Matrícula: {0}", matricula);
        }
    }
}
