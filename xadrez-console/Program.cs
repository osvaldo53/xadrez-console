using System;
using Tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(1, 2);
            Console.Write(p);

            Console.ReadKey();
        }
    }
}
