namespace ListPOOsampltwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Livro livro1 = new Livro("Aventuras de Sherlock Holmes", "Arthur Conan Doyle", 1892);
            Livro livro2 = new Livro("1984", "George Orwell", 1949);
            Livro livro3 = new Livro("O Hobbit", "J.R.R. Tolkien", 1937);

            biblioteca.AdicionarLivro(livro1);
            biblioteca.AdicionarLivro(livro2);
            biblioteca.AdicionarLivro(livro3);

            Console.WriteLine("Todos os livros na biblioteca:");
            biblioteca.ListarLivros();

            Console.WriteLine("Pesquisar livros com o título '1984':");
            biblioteca.PesquisarLivroPorTitulo("1984");
        }
    }
}