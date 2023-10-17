using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poli
{
    internal class Animal
    {

        public int NumPatass { get; set; }

        public Animal()
        {
            NumPatass = 0;
        }
        public Animal(int numPatass) {
            NumPatass = numPatass;
        }
        public virtual void FazerSom()
        {
            Console.WriteLine("Som genérico de um animal.");
        }
    }
}
