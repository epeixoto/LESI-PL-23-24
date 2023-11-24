namespace exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar uma conta poupança
            ContaPoupanca poupanca = new ContaPoupanca(1, 1000, 0.03);

            // Depositar na conta poupança
            poupanca.Depositar(500);

            // Levantar da conta poupança
            poupanca.Levantar(200);

            // Calcular os juros na conta poupança
            poupanca.CalcularJuros();

            // Criar uma conta salário
            ContaSalario salario = new ContaSalario(2, 2000, "EmpresaA");

            // Depositar na conta salário
            salario.Depositar(1000);

            // Pagar salário na conta salário
            salario.PagarSalario(1500);

            // Mostrar informações das contas utilizando a interface IOperacoes
            MostrarInformacoes(poupanca);
            MostrarInformacoes(salario);
        }
        static void MostrarInformacoes(IOperacoes operacoes)
        {
            Console.WriteLine($"Tipo de conta: {operacoes.GetType().Name}");

            Conta outraConta = new Conta(3, 500);
            if (operacoes.InserirElemento(outraConta))
            {
                Console.WriteLine("Elemento inserido com sucesso.");
            }
            else
            {
                Console.WriteLine("Erro ao inserir elemento.");
            }

            if (operacoes.RemoverElemento(outraConta))
            {
                Console.WriteLine("Elemento removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Erro ao remover elemento.");
            }

            if (operacoes.AtualizarElemento(operacoes))
            {
                Console.WriteLine("Elemento atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Erro ao atualizar elemento.");
            }

            var listaContas = operacoes.SelecionarElementos(typeof(Conta));
            if (listaContas != null)
            {
                Console.WriteLine($"Número total de contas: {(listaContas as List<Conta>)?.Count}");
            }
            else
            {
                Console.WriteLine("Erro ao selecionar elementos.");
            }

            Console.WriteLine();
        }
    }
}