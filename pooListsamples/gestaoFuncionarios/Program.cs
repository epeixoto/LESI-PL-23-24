namespace gestaoFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Funcionario funcionario = new Funcionario("", 5000, -1);

                Console.WriteLine("Nome: {0}", funcionario.Nome);
                Console.WriteLine("Salário Base: {0}", funcionario.SalarioBase);
                Console.WriteLine("Idade: {0} anos", funcionario.Idade);

                double desempenho = -1;
                double bonus = funcionario.CalcularBonus(desempenho);

                Console.WriteLine("O Bônus com desempenho {0}: {1}", desempenho, bonus);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}