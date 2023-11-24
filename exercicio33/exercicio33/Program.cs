namespace exercicio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorEspetaculos gestor = new GestorEspetaculos();

            // Guardar espetáculos
            Espetaculo espetaculo1 = new Espetaculo("Concerto", "Sala A", new DateTime(2023, 12, 1, 19, 30, 0), 100);
            Espetaculo espetaculo2 = new Espetaculo("Teatro", "Sala B", new DateTime(2023, 12, 5, 20, 0, 0), 150);

            gestor.GuardarEspetaculo(espetaculo1);
            gestor.GuardarEspetaculo(espetaculo2);

            // Consultar espetáculos
            Console.WriteLine("Espetáculos Registrados:");
            gestor.ConsultarEspetaculos();

            // Adquirir bilhetes
            gestor.AdquirirBilhetes("Concerto", "Cliente1", 50);

            // Detalhes dos espectadores
            gestor.DetalhesEspectadores("Concerto");

            // Histórico de espetáculos
            gestor.HistoricoEspetaculos(new DateTime(2023, 11, 1), new DateTime(2023, 12, 31));

            // Guardar e carregar em arquivo
            gestor.GuardadosEmFicheiro("dados.bin");

            // Reiniciar o gestor
            gestor = new GestorEspetaculos();
            gestor.CarregarDeFicheiro("dados.bin");

            // Consultar espetáculos novamente após carregar do arquivo
            Console.WriteLine("Espetáculos Guardados Após Carregar do Arquivo:");
            gestor.ConsultarEspetaculos();
        }
    }
}