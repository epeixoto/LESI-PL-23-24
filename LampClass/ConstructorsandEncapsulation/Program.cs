namespace ConstructorsandEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa("João Silva");
            Pessoa pessoa3 = new Pessoa(18);
            Pessoa pessoa4 = new Pessoa("João Silva", 18);

            pessoa1.VerInfo();
            pessoa2.VerInfo();
            pessoa3.VerInfo();
            pessoa4.VerInfo();
        }
    }
}