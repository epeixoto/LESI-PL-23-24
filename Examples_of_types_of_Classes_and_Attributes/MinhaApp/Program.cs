namespace MinhaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinhaClasseDerivada minhaInstancia = new MinhaClasseDerivada();

             minhaInstancia.MetodoDerivado();

            Aluno2 aluno = new Aluno2("Nuno", 100, "12345");

            // Chama o método público da classe base (Pessoa)
            aluno.MostrarInformacoes();
            aluno.MostrarMatricula();
        }
    }
}