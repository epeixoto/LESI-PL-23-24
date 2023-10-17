namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Dimensoes(12.7, 15.0, 15.0);
            string tipo = triangulo.Tipo();
            Console.WriteLine("O triângulo é: " + tipo);
        }
    }
}