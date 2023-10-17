using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listHeranca
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade
        {
            get; set;
        }

    public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Olá, o meu nome é {0} e tenho {1} anos.", Nome, Idade);
        }
    }
}
