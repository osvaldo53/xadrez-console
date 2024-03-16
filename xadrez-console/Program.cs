using System;
using XadrezTabuleiro;
using Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.Write(pos.ToPosicao());

            Console.ReadKey();
        }
    }
}
