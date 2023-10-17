using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lojaOnline
{
    internal class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto()
        {

        }
        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
