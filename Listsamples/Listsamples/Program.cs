namespace Listsamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            while (true)
            {
                Console.Write("Introduza um número (ou '0' para sair): ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                    break;

                numeros.Add(numero);
            }

            Console.WriteLine("Números na lista:");

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }


        }
    }
}