using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtherDocumentation
{
    /// <summary>
    /// Classe derivada "Gato" herda de "Animal".
    /// </summary>
    public class Gato : Animal
    {
        /// <summary>
        /// Inicializa uma nova instância da classe Gato com um nome e idade.
        /// </summary>
        /// <param name="nome">O nome do gato.</param>
        /// <param name="idade">A idade do gato.</param>
        public Gato(string nome, int idade) : base(nome, idade) { }

        /// <summary>
        /// Método para fazer o gato miar.
        /// </summary>
        public void SomdoGato()
        {
            Console.WriteLine("O gato!");
        }
    }
}
