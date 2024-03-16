using System;
using XadrezTabuleiro;
using Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Rei(Cor.Preta, tabuleiro), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(0, 9));

                Tela.ImprimirTabuleiro(tabuleiro);



                Console.ReadKey();
            }
            catch (TabuleiroException e)
            {
                Console.Write(e.Message);
            }

            Console.ReadKey();
        }
    }
}
