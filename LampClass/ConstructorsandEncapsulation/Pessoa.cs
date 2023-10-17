using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsandEncapsulation
{
    internal class Pessoa
    {
        private string Nome;
        private int Idade;

        // Construtor sem parâmetros
        public Pessoa()
        {
            Nome = "";
            Idade = 0;
        }

        // Construtor com nome
        public Pessoa(string nome)
        {
            Nome = nome;
            Idade = 0;
        }

        // Construtor com idade
        public Pessoa(int idade)
        {
            Nome = "";
            Idade = idade;
        }

        // Construtor com nome e idade
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void VerInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}
