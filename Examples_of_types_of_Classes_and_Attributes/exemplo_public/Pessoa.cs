using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_public
{
    internal class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Método público
        public void MostraInfo()
        {
            Console.WriteLine("Olá, o meu nome é {0} e tenho {1} anos.", Nome, Idade);
        }

    }
}
