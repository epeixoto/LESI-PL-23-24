using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poli
{
    internal class Gato : Animal
    {
        public int NumPatas { get; set; }
        public Gato()
        {
            NumPatas = 0;
        }

        public Gato(int numPtas) {
            NumPatas = numPtas;
        }

        public void MostraNumPatas()
        {
            Console.WriteLine(NumPatas);
        }
        public override void FazerSom()
        {
            Console.WriteLine("Som do gato..");
        }
    }
}
