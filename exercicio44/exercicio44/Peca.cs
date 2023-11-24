using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio44
{
    internal class Peca
    {
        // Classe base para todas as peças
        public virtual void Desenhar()
        {
            Console.Write("-");
        }
    }
}
