using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //Modelo da dados
    public class Pessoa
    {
        private int _idade;

        public int Id { get; set; }
        public string Nome { get; set; }

        public int Idade
        {
            get => _idade;
            set
            {
                if (value >= 0)
                {
                    _idade = value;
                }
                else
                {
                    throw new ArgumentException("A idade deve ser um número não negativo.");
                }
            }
        }
    }
}
