namespace _1exemplodecamadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productBLL = new ProductBLL();

            while (true)
            {
                Console.WriteLine("1. Listar produtos");
                Console.WriteLine("2. Adicionar produto");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ListProducts(productBLL.GetAllProducts());
                        break;
                    case 2:
                        AddProduct(productBLL);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void ListProducts(List<Product> products)
        {
            Console.WriteLine("Lista de produtos:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id}: {product.Name} - {product.Price} €");
            }
        }

        static void AddProduct(ProductBLL productBLL)
        {
            Console.Write("Nome do produto: ");
            string name = Console.ReadLine();
            Console.Write("Preço do produto: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Product product = new Product
            {
                Id = Guid.NewGuid(),
                Name = name,
                Price = price
            };

            productBLL.AddProduct(product);
            Console.WriteLine("Produto adicionado com sucesso!");
        }
    }
}