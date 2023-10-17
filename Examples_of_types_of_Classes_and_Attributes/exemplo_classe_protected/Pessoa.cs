using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_classe_protected
{
    public class Pessoa
    {
        // Atributos protegidos
        protected string nome;
        protected int idade;

        // Construtor
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        // Método público para mostrar as informações gerais
        public void MostrarInformacoes()
        {
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Idade: {0} anos", idade);
        }
    }
}
