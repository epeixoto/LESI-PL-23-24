using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio33
{
    internal class Bilhete
    {
        public string NomeCliente { get; set; }
        public int Quantidade { get; set; }

        public Bilhete(string nomeCliente, int quantidade)
        {
            NomeCliente = nomeCliente;
            Quantidade = quantidade;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Cliente: {NomeCliente}");
            Console.WriteLine($"Quantidade: {Quantidade}");
        }
    }
}
