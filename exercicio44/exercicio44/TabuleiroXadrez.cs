using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio44
{
    internal class TabuleiroXadrez
    {
        private Peca[,] tabuleiro;

        public TabuleiroXadrez()
        {
            // Inicializa o tabuleiro de xadrez
            tabuleiro = new Peca[8, 8];
        }

        public void ColocarPeca(Peca peca, int i, int j)
        {
            // Coloca uma peça na posição i, j
            if (PosicaoValida(i, j))
            {
                tabuleiro[i, j] = peca;
                Console.WriteLine($"Peça {peca.GetType().Name} colocada na posição: {i}, {j}");
            }
            else
            {
                Console.WriteLine("Posição inválida para a peça.");
            }
        }

        public bool PosicaoOcupada(int i, int j)
        {
            // Verifica se a posição está ocupada
            if (PosicaoValida(i, j))
            {
                if (tabuleiro[i, j] != null)
                {
                    Console.WriteLine($"Posição {i}, {j} ocupada por uma peça.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Posição {i}, {j} está vazia.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Posição inválida.");
                return false;
            }
        }

        public void PosicoesDosBispos()
        {
            // Indica as posições dos bispos
            Console.WriteLine("Posições dos Bispos:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tabuleiro[i, j] is Bispo)
                    {
                        Console.WriteLine($"Bispo na posição: {i}, {j}");
                    }
                }
            }
        }

        public void DesenharTabuleiro()
        {
            // Desenha o tabuleiro com as peças
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tabuleiro[i, j] != null)
                    {
                        tabuleiro[i, j].Desenhar();
                    }
                    else
                    {
                        Console.Write("-");
                    }

                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private bool PosicaoValida(int i, int j)
        {
            // Verifica se a posição está dentro dos limites do tabuleiro
            return i >= 0 && i < 8 && j >= 0 && j < 8;
        }
    }
}
