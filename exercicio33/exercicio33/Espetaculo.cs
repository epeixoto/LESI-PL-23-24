using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace exercicio33
{
    [Serializable]
    internal class Espetaculo
    {
        public string Nome { get; set; }
        public string Sala { get; set; }
        public DateTime DataHora { get; set; }
        public int NumeroLugares { get; set; }
        public int LugaresReservados { get; set; }

        public Espetaculo(string nome, string sala, DateTime dataHora, int numeroLugares)
        {
            Nome = nome;
            Sala = sala;
            DataHora = dataHora;
            NumeroLugares = numeroLugares;
            LugaresReservados = 0;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Espetáculo: {Nome}");
            Console.WriteLine($"Sala: {Sala}");
            Console.WriteLine($"Data e Hora: {DataHora}");
            Console.WriteLine($"Número de Lugares: {NumeroLugares}");
            Console.WriteLine($"Lugares Reservados: {LugaresReservados}");
        }
    }
}
