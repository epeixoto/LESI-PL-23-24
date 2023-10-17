using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poli
{
    internal class Cao : Animal
    {

        public Cao()
        {
            NumPatass = 0;
        }
        public Cao(int numPatass) : base(numPatass) {
            NumPatass = numPatass;
        }
        public override void FazerSom()
        {
            Console.WriteLine("Som do cão..");
        }
    }
}
