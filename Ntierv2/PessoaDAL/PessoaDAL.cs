using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // Camada de acesso a dados
    public class PessoaDAL
    {
        private const string FilePath = "pessoas.csv";

        public static void AdicionarPessoa(Pessoa pessoa)
        {
            // Lógica para adicionar a pessoa num ficheiro CSV
            var linha = $"{pessoa.Id},{pessoa.Nome},{pessoa.Idade}";
            File.AppendAllLines(FilePath, new[] { linha });
        }

        public static List<Pessoa> ObterTodasPessoas()
        {
            var linhas = File.ReadAllLines(FilePath);
            var pessoas = new List<Pessoa>();

            foreach (var linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha))
                {
                    continue;
                }

                var campos = linha.Split(',');

                if (int.TryParse(campos[0], out int id) && int.TryParse(campos[2], out int idade))
                {
                    var pessoa = new Pessoa
                    {
                        Id = id,
                        Nome = campos[1],
                        Idade = idade
                    };
                    pessoas.Add(pessoa);
                }
                else
                {
                    Console.WriteLine($"Ignora linhas inválidas: {linha}");
                }
            }

            return pessoas;
        }
    }
}
