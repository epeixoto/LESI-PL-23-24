using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherDocumentation
{
    /// <summary>
    /// Classe base que representa um animal.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Obtém ou define o nome do animal.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Obtém ou define a idade do animal.
        /// </summary>
        public int Idade { get; set; }

        /// <summary>
        /// Inicializa uma nova instância da classe Animal com um nome e idade.
        /// </summary>
        /// <param name="nome">O nome do animal.</param>
        /// <param name="idade">A idade do animal.</param>
        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        /// <summary>
        /// Método virtual para emitir um som genérico.
        /// </summary>
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal emite um som genérico.");
        }
    }
}
