namespace OrdenacaoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 5, 2, 9, 1, 7 };

            Console.WriteLine("Lista original:");

            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }

            numeros.Sort();

            Console.WriteLine("\nLista ordenada pela ordem crescente:");

            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }
        }
    }
}