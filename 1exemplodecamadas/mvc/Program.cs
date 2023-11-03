namespace mvc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TarefaController controller = new TarefaController();
            controller.Executar();
        }
    }
}