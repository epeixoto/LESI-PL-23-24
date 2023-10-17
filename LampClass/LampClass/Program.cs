namespace LampClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampada lampada = new Lampada();
            Console.WriteLine("Estado: " + lampada.Estado());
            lampada.Acender();
            Console.WriteLine("Estado: " + lampada.Estado()); 
            lampada.Apagar();
            Console.WriteLine("Estado: " + lampada.Estado());
        }
    }
}