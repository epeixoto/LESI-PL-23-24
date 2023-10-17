namespace listMaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Console.Write("Quantos números deseja adicionar à lista? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Introduza o número {0}: ", i + 1);
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

            int maior = numeros.Max();
            int menor = numeros.Min();

            Console.WriteLine("Maior número na lista: " + maior);
            Console.WriteLine("Menor número na lista: " + menor);
        }
    }
}