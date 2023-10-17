namespace listHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa("Filipe", 25));
            pessoas.Add(new Aluno("Joana", 20, 1001));
            pessoas.Add(new Aluno("Rita", 22, 1002));

            Console.WriteLine("Apresentação dos alunos:");
            foreach (var pessoa in pessoas)
            {
                pessoa.Mostrar();
            }
        }
    }
}