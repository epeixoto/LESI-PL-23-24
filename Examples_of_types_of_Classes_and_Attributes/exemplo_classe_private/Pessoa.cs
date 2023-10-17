using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_classe_private
{
    internal class Pessoa
    {
        // Atributos privados
        private string nome;
        private int idade;

        // Construtor
        public Pessoa(string nome, int idade)
        {
            // Iniciar os atributos privados no construtor
            this.nome = nome;
            this.idade = idade;
        }

        // Método público para exibir o nome (aceder a um atributo privado)
        public void MostraNome()
        {
            Console.WriteLine("Nome: {0}", nome);
        }

        // Método público para mostra a idade (aceder a um atributo privado)
        public void MostraIdade()
        {
            Console.WriteLine("Idade: {0} anos", idade);
        }
    }
}
