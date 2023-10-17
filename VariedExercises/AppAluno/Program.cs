namespace herance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Filipe", 29, "12345", "POO");

            a.Apresentar();

            Console.WriteLine("Matrícula: {0}", a.Matricula);

            a.Estudar();

        }
    }
}