using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAviao
{
    internal class Aviao
    {
        // Atributos da classe
        public string Modelo { get; set; }
        public int Velocidade { get; private set; }
        public int Altitude { get; private set; }
        public string Marca { get; set; }

        // Construtor
        public Aviao(string modelo, string marca)
        {
            Modelo = modelo;
            Marca = marca;
            Velocidade = 0;
            Altitude = 0;
        }

        // Método para acelerar o avião
        public void Acelerar(int aumentoDeVelocidade)
        {
            Velocidade += aumentoDeVelocidade;
            Console.WriteLine("O avião acelerou para {0} km/h.", Velocidade);
        }

        // Método para reduzir a velocidade do avião
        public void Reduzir(int reducaoDeVelocidade)
        {
            Velocidade -= reducaoDeVelocidade;
            Console.WriteLine("O avião reduziu para {0} km/h.", Velocidade);
        }

        // Método para subir a altitude do avião
        public void Subir(int aumentoDeAltitude)
        {
            Altitude += aumentoDeAltitude;
            Console.WriteLine("O avião subiu para {0} metros de altitude.", Altitude);
        }

        // Método para descer a altitude do avião
        public void Descer(int reducaoDeAltitude)
        {
            Altitude -= reducaoDeAltitude;
            Console.WriteLine("O avião desceu para {0} metros de altitude.", Altitude);
        }
    }
}
