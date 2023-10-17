using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPOOsampltwo
{
    internal class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void ListarLivros()
        {
            Console.WriteLine("Livros que estão disponiveis na biblioteca:");
            foreach (var livro in livros)
            {
                Console.WriteLine("Título: {0}, Autor: {1}, Ano de Publicação: {3}", 
                    livro.Titulo, livro.Autor, livro.AnoPublicacao);
            }
        }

        public void PesquisarLivroPorTitulo(string titulo)
        {
            var resultados = livros.Where(livro => livro.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();

            if (resultados.Count > 0)
            {
                Console.WriteLine("Livros encontrados com o título '" + titulo + "':");
                foreach (var livro in resultados)
                {
                    Console.WriteLine("Título: {0}, Autor: {1}, Ano de Publicação: {2}",
                        livro.Titulo, livro.Autor, livro.AnoPublicacao);
                }
            }
            else
            {
                Console.WriteLine("Nenhum livro encontrado com o título '" + titulo + "'.");
            }
        }
    }
}
