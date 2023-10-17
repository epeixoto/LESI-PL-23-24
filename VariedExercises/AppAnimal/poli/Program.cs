namespace poli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chamar os metodos:
            Animal animal = new Cao();
            Animal animal2 = new Gato();

            animal.FazerSom();
            animal2.FazerSom();

            Gato g = new Gato();
            Console.WriteLine(g.NumPatas);
            Gato g2 = new Gato(4);
            Console.WriteLine(g2.NumPatas);
            g2.NumPatas = 10;    
            Console.WriteLine(g2.NumPatas);
            g2.MostraNumPatas();


            Cao c = new Cao();
            c.FazerSom();
        }
    }
}