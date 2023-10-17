namespace lojaOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LojaOnline minhaLoja = new LojaOnline();

            minhaLoja.MostrarProdutosDisponiveis();

            minhaLoja.AdicionarAoCarrinho("Camisola");
            minhaLoja.AdicionarAoCarrinho("Calças");
            minhaLoja.AdicionarAoCarrinho("Sapatos");

            minhaLoja.MostrarCarrinho();

            decimal totalDaCompra = minhaLoja.CalcularTotalDaCompra();
            Console.WriteLine("Total da compra: {0}", totalDaCompra);

            minhaLoja.FinalizarCompra();
        }
    }
}