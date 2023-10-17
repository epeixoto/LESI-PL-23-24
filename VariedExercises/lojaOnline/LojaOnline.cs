using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaOnline
{
    internal class LojaOnline
    {
        private List<Produto> produtosDisponiveis = new List<Produto>();
        private List<Produto> carrinho = new List<Produto>();

        public LojaOnline()
        {
            // ProdutosDisponiveis
            Produto produto = new Produto();
            produto.Nome = "Camisola";
            produto.Preco = 20;

            Produto produto2 = new Produto();
            produto2.Nome = "Calças";
            produto2.Preco = 40;

            produtosDisponiveis.Add(produto);
            produtosDisponiveis.Add(produto2);
        }

        public void MostrarProdutosDisponiveis()
        {
            Console.WriteLine("Produtos Disponíveis:");
            foreach (var produto in produtosDisponiveis)
            {
                Console.WriteLine("{0} - {1}", produto.Nome, produto.Preco  );
            }
        }

        public void AdicionarAoCarrinho(string nomeProduto)
        {
            // Procura o produto na lista de produtos disponíveis
            var produtoSelecionado = produtosDisponiveis.FirstOrDefault(p => p.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));

            if (produtoSelecionado != null)
            {
                carrinho.Add(produtoSelecionado);
                Console.WriteLine("{0} foi adicionado ao carrinho.", produtoSelecionado.Nome);
            }
            else
            {
                Console.WriteLine("Produto não está disponível.");
            }
        }

        public void MostrarCarrinho()
        {
            Console.WriteLine("Carrinho de Compras:");
            foreach (var produto in carrinho)
            {
                Console.WriteLine("{0} - {1}", produto.Nome, produto.Preco);
            }
        }
        public decimal CalcularTotalDaCompra()
        {
            return carrinho.Sum(p => p.Preco);
        }

        public void FinalizarCompra()
        {
            decimal totalDaCompra = CalcularTotalDaCompra();
            Console.WriteLine("Total da compra: {0}", totalDaCompra);
            Console.WriteLine("Pagamento realizado com sucesso. Muito Obrigado!");
            carrinho.Clear();
        }
    }
}
