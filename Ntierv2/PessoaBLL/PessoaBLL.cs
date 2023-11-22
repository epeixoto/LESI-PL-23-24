using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    // Camada de lógica de negócios
    public class PessoaBLL
    {
        // Função auxiliar para adicionar uma pessoa
        public static void AdicionarPessoa(int id, string nome, int idade)
        {
            var novaPessoa = new Pessoa { Id = id, Nome = nome, Idade = idade };

            PessoaDAL.AdicionarPessoa(novaPessoa);
        }


        // Função auxiliar para obter todas as pessoas
        public static List<Pessoa> ObterTodasPessoas()
        {
            return PessoaDAL.ObterTodasPessoas();
        }
    }
}
