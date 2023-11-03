using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc
{
    internal class TarefaView
    {
        public void MostrarListaDeTarefas(List<Tarefa> tarefas)
        {
            Console.WriteLine("Lista de Tarefas:");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"{tarefa.Descricao} - {(tarefa.Concluida ? "Concluída" : "Pendente")}");
            }
        }

        public string ObterDescricaoDaTarefa()
        {
            Console.Write("Introduza a descrição da tarefa: ");
            return Console.ReadLine();
        }
    }
}
