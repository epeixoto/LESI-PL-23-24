using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampClass
{
    internal class Lampada
    {
        private bool ligada;

        public Lampada()
        {
            ligada = false;
        }

        public void Acender()
        {
            ligada = true;
        }

        public void Apagar()
        {
            ligada = false;
        }

        public string Estado()
        {
            return ligada ? "ligada" : "desligada"; //Ternary operator
        }
    }
}
