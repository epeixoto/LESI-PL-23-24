using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherDocumentation
{
    /// <summary>
    /// Classe derivada "Cão" herda de "Animal".
    /// </summary>
    public class Cao : Animal
    {
        /// <summary>
        /// Inicializa uma nova instância da classe Cão com um nome e idade.
        /// </summary>
        /// <param name="nome">O nome do Cão.</param>
        /// <param name="idade">A idade do Cão.</param>
        public Cao(string nome, int idade) : base(nome, idade) { }

        /// <summary>
        /// Método para fazer o Cão.
        /// </summary>
        public void SomdoCao()
        {
            Console.WriteLine("O Cão ");
        }
    }
}
