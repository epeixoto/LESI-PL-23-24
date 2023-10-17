namespace exemplo_public
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar o objecto
            Pessoa pessoa = new Pessoa("Filipe", 28);

            //Chama o método público
            pessoa.MostraInfo();
        }
    }
}