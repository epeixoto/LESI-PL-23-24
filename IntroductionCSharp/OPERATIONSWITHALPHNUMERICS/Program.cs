namespace OPERATIONSWITHALPHNUMERICS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porto".Length);
            Console.WriteLine("Lisboa " + "é a capital de Portugal");
            Console.WriteLine("Coimbra".ToUpper());
            Console.WriteLine("Maria Adelaide Carvalho".Substring(6, 9));
            Console.WriteLine("Porto tricampeao".IndexOf("tri"));
            Console.WriteLine("Porto".CompareTo("Lisboa"));
            Console.WriteLine("Lisboa".CompareTo("Porto"));
            Console.WriteLine(" Porto ".Trim());
        }
    }
}