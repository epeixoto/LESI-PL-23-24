namespace ConstructorsandEncapsulationV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angulo angulo = new Angulo();
            angulo.Grau = 180.0;
            double cos180 = angulo.Cos();

            angulo.Radiano = Math.PI / 2;
            double graus90 = angulo.Grau;

            Console.WriteLine($"Cos(180 graus) = {cos180}");
            Console.WriteLine($"PI/2 = {graus90} graus");
        }
    }
}