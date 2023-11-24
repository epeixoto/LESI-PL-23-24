using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio22
{
    internal interface IOperacoes
    {
        bool InserirElemento(object x);
        bool RemoverElemento(object x);
        bool AtualizarElemento(object x);
        object SelecionarElementos(Type typeValue);
    }
}
