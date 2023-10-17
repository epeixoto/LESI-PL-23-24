using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        public Triangulo()
        {
            ladoA = 0.0;
            ladoB = 0.0;
            ladoC = 0.0;
        }

        public void Dimensoes(double A, double B, double C)
        {
            ladoA = A;
            ladoB = B;
            ladoC = C;
        }

        public string Tipo()
        {
            if (ladoA == ladoB && ladoB == ladoC)
            {
                return "equilátero";
            }
            else if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
            {
                return "escaleno";
            }
            else
            {
                return "isósceles";
            }
        }
    }
}
