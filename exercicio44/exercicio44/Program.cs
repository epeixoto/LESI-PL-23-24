namespace exercicio44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar o tabuleiro de xadrez
            TabuleiroXadrez tabuleiroXadrez = new TabuleiroXadrez();

            // Criar uma torre e bispo
            Torre torre = new Torre();
            Bispo bispo = new Bispo();

            // Colocar uma torre na posição 3, 4 e bispo 5,5
            tabuleiroXadrez.ColocarPeca(torre, 3, 4);
            tabuleiroXadrez.ColocarPeca(bispo, 5, 5);

            // Verificar se a posição 3, 4 está ocupada
            tabuleiroXadrez.PosicaoOcupada(3, 4);

            // Mostra as posições dos bispos
            tabuleiroXadrez.PosicoesDosBispos();

            // Desenhar o tabuleiro
            tabuleiroXadrez.DesenharTabuleiro();
        }
    }
}