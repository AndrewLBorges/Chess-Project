using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            Tela.ImprimirTabuleiro(partida.Tabuleiro);
            Console.WriteLine();

            ImprimirPecasCapturadas(partida);

            Console.WriteLine();
            Console.WriteLine($"Turno: {partida.Turno}");
            Console.WriteLine($"Aguardando jogada: {partida.JogadorAtual}");

            if(partida.Check)
            {
                Console.WriteLine("CHECK!");
            }
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas:");
            Console.Write("Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
            Console.WriteLine();

            Console.Write("Pretas: ");
            ConsoleColor original = Console.ForegroundColor;
            ConsoleColor preta = ConsoleColor.Cyan;
            Console.ForegroundColor = preta;
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = original;


            Console.WriteLine();
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach(Peca p in conjunto)
            {
                Console.Write($"{p} ");
            }
            Console.Write("]");
        }
        
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    Peca peca = tab.PegaPeca(i, j);

                    ImprimirPeca(peca);
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;

            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if(posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    Peca peca = tab.PegaPeca(i, j);

                    ImprimirPeca(peca);
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse($"{s[1]}");
            return new PosicaoXadrez(coluna, linha);

        }
        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Cor.Branca)
                {
                    Console.Write($"{peca} ");
                }
                else
                {
                    ConsoleColor x = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"{peca} ");
                    Console.ForegroundColor = x;
                }
            }
        }
    }
}
