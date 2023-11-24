using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace exercicio33
{
    internal class GestorEspetaculos
    {
        private List<Espetaculo> espetaculos;

        public GestorEspetaculos()
        {
            espetaculos = new List<Espetaculo>();
        }

        public void GuardarEspetaculo(Espetaculo espetaculo)
        {
            espetaculos.Add(espetaculo);
            Console.WriteLine($"Espetáculo '{espetaculo.Nome}' guardado com sucesso!");
        }

        public void ConsultarEspetaculos()
        {
            foreach (var espetaculo in espetaculos)
            {
                espetaculo.MostrarDetalhes();
                Console.WriteLine();
            }
        }

        public void AdquirirBilhetes(string nomeEspetaculo, string nomeCliente, int quantidade)
        {
            var espetaculo = espetaculos.Find(e => e.Nome == nomeEspetaculo);

            if (espetaculo != null)
            {
                if (quantidade <= (espetaculo.NumeroLugares - espetaculo.LugaresReservados))
                {
                    espetaculo.LugaresReservados += quantidade;
                    Bilhete bilhete = new Bilhete(nomeCliente, quantidade);
                    bilhete.MostrarDetalhes();
                }
                else
                {
                    Console.WriteLine("Não há lugares suficientes disponíveis.");
                }
            }
            else
            {
                Console.WriteLine("Espetáculo não encontrado.");
            }
        }

        public void DetalhesEspectadores(string nomeEspetaculo)
        {
            var espetaculo = espetaculos.Find(e => e.Nome == nomeEspetaculo);

            if (espetaculo != null)
            {
                Console.WriteLine($"Detalhes dos espectadores do espetáculo '{nomeEspetaculo}':");
            }
            else
            {
                Console.WriteLine("Espetáculo não encontrado.");
            }
        }

        public void HistoricoEspetaculos(DateTime inicio, DateTime fim)
        {
            Console.WriteLine($"Histórico de espetáculos no período de {inicio} a {fim}:");
        }

        public void GuardadosEmFicheiro(string nomeFicheiro)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(nomeFicheiro, FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, espetaculos);
                    Console.WriteLine("Dados guardados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao guardar dados: {ex.Message}");
            }
        }

        public void CarregarDeFicheiro(string nomeArquivo)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(nomeArquivo, FileMode.Open, FileAccess.Read))
                {
                    espetaculos = (List<Espetaculo>)formatter.Deserialize(stream);
                    Console.WriteLine("Dados carregados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar dados: {ex.Message}");
            }
        }
    }
}
