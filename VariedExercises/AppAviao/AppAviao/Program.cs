namespace AppAviao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aviao meuAviao = new Aviao("Boeing 747", "Boeing");

            meuAviao.Acelerar(300);
            meuAviao.Subir(5000);
            meuAviao.Reduzir(100);
            meuAviao.Descer(2000);
        }
    }
}