namespace exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar listas de contas
            List<Conta> contasBancarias = new List<Conta>();
            List<ContaSalario> contasSalario = new List<ContaSalario>();
            List<Conta> contas = new List<Conta>();

            // Adicionar algumas contas para teste
            ContaPoupanca poupanca1 = new ContaPoupanca(1, 1000, 0.03);
            ContaSalario salario1 = new ContaSalario(2, 2000, "EmpresaA");
            Conta poupanca2 = new Conta(3, 1500);

            contasBancarias.Add(poupanca1);
            contasSalario.Add(salario1);
            contas.Add(poupanca2);

            // Mostrar informações das contas
            foreach (var conta in contasBancarias)
            {
                Console.WriteLine($"Conta Poupança - Número: {conta.NumeroConta}, Saldo: {conta.Saldo}");
            }

            foreach (var conta in contasSalario)
            {
                Console.WriteLine($"Conta Salário - Número: {conta.NumeroConta}, Saldo: {conta.Saldo}, Empresa: {conta.Empresa}");
            }

            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta - Número: {conta.NumeroConta}, Saldo: {conta.Saldo}");
            }
        }
    }
}