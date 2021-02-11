using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez px = new PosicaoXadrez('c', 7);

            Console.WriteLine(px);
            Console.WriteLine(px.ToPosicao());
        }
    }
}
