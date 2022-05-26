using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posXa = new PosicaoXadrez('c', 7);

            Console.WriteLine(posXa);
            Console.WriteLine(posXa.toPosicao());

            Console.ReadKey();
        }
    }
}
