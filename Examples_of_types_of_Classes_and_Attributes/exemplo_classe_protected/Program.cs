namespace exemplo_classe_protected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Nuno", 100, "12345");

            // Chama o método público da classe base (Pessoa)
            aluno.MostrarInformacoes();

            // Chama método público da classe derivada (Aluno)
            aluno.MostrarMatricula();
        }
    }
}