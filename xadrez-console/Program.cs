using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(3, 6);

            Console.WriteLine($"Posicao: {p}");
        }
    }
}
