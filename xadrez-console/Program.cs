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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutarMovimento(origem, destino);

                }
                

                Tela.ImprimirTabuleiro(partida.tab);

            }
            catch (TabuleiroException e)
            {
                Console.Write(e.Message);
            }

            Console.ReadKey();
        }
    }
}
