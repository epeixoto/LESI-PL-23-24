namespace LOGICALOPERATIONS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(4 == 5);
            Console.WriteLine(4 != 6);
            Console.WriteLine(4 > 5);
            Console.WriteLine(4 < 5 && 6 > 10);
            Console.WriteLine(40 < 50 || 60 > 90);
            Console.WriteLine(!(40 < 50 || 60 > 90));
        }
    }
}