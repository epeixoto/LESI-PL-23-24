using BLL;

namespace Ntierv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaBLL.AdicionarPessoa(1, "Filipa", 29);

            var todasPessoas = PessoaBLL.ObterTodasPessoas();

            foreach (var pessoa in todasPessoas)
            {
                Console.WriteLine($"ID: {pessoa.Id}, Nome: {pessoa.Nome}," +
                    $" Idade: {pessoa.Idade}");
            }
        }
    }
}