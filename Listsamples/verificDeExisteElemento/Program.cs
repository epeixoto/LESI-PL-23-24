using System.Linq;

namespace verificDeExisteElemento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string> { "João", "Maria", 
                "Filipe", "Rita", "Ana" };

            Console.Write("Introduza um nome para verificar se existe na lista: ");
            string nome = Console.ReadLine();

            if (nomes.Contains(nome))
            {
                Console.WriteLine(nome + " existe na lista.");
            }
            else
            {
                Console.WriteLine(nome + " não existe na lista.");
            }
        }
    }
}