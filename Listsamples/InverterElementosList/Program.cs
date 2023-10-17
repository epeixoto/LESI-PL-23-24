namespace InverterElementosList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Lista original:");

            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }

            numeros.Reverse();

            Console.WriteLine("\nLista invertida:");

            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }
        }
    }
}