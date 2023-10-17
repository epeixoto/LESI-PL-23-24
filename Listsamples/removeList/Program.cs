namespace removeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string> { "João", "Maria",
                "Filipe", "Rita", "Ana" };

            Console.WriteLine("Nomes da lista:");

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.Write("Introduxs o nome que deseja remover da lista: ");
            string nomeRemover = Console.ReadLine();

            nomes.Remove(nomeRemover);

            Console.WriteLine("Nomes da lista após remover o nome :");

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}