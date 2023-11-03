using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc
{
    internal class TarefaController
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        private TarefaView view = new TarefaView();

        public void AdicionarTarefa(string descricao)
        {
            tarefas.Add(new Tarefa { Descricao = descricao, Concluida = false });
        }

        public void ListarTarefas()
        {
            view.MostrarListaDeTarefas(tarefas);
        }

        public void Executar()
        {
            bool executando = true;
            while (executando)
            {
                view.MostrarListaDeTarefas(tarefas);
                Console.WriteLine("Opções:");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        string descricao = view.ObterDescricaoDaTarefa();
                        AdicionarTarefa(descricao);
                        break;
                    case "2":
                        executando = false;
                        break;
                }
            }
        }
    }
}
