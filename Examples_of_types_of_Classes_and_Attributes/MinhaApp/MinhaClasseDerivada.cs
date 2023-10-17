using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;


namespace MinhaApp
{
    internal class MinhaClasseDerivada : MinhaClasse
    {
        public void MetodoDerivado()
        {
            MetodoProtegidoInterno(); // Aceder ao método protegido interno
        }
    }
}
