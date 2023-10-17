namespace pooListsamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso cursoCSharp = new Curso("Programação em C# (POO)");

            Aluno aluno1 = new Aluno("Nuno", 1001);
            Aluno aluno2 = new Aluno("Maria", 1002);
            Aluno aluno3 = new Aluno("Ana", 1003);

            cursoCSharp.AdicionarAluno(aluno1);
            cursoCSharp.AdicionarAluno(aluno2);
            cursoCSharp.AdicionarAluno(aluno3);

            cursoCSharp.ListarAlunos();
        }
    }
}