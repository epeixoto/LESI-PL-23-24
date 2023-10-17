using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsandEncapsulationV2
{
    internal class Angulo
    {
        private double grau;
        private double radiano;

        public Angulo()
        {
            grau = 0.0;
            radiano = 0.0;
        }

        public double Grau
        {
            get { return grau; }
            set
            {
                grau = value;
                radiano = grau / 180.0 * Math.PI;
            }
        }

        public double Radiano
        {
            get { return radiano; }
            set
            {
                radiano = value;
                grau = radiano / Math.PI * 180;
            }
        }

        public double Cos()
        {
            return Math.Cos(radiano);
        }
    }
}
