﻿using System;
using tabuleiro;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.WriteLine(tab);

            Console.ReadKey();
        }
    }
}
