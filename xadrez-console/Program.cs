using System;
using XadrezTabuleiro;
using Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.ColocarPeca(new Rei(Cor.Preta, tabuleiro), new Posicao(0, 0));

            Tela.ImprimirTabuleiro(tabuleiro);

            

            Console.ReadKey();
        }
    }
}
