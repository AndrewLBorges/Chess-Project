﻿using tabuleiro;

namespace xadrez
{
    class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.PegaPeca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.PegaPeca(pos) != null && Tab.PegaPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna);
            }

            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.PegaPeca(pos) != null && Tab.PegaPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna);
            }

            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.PegaPeca(pos) != null && Tab.PegaPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha, pos.Coluna + 1);
            }

            //esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.PegaPeca(pos) != null && Tab.PegaPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha, pos.Coluna - 1);
            }

            //noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.PegaPeca(pos) != null && Tab.PegaPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            //nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.PegaPeca(pos) != null && Tab.PegaPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            //sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.PegaPeca(pos) != null && Tab.PegaPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            //sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.PegaPeca(pos) != null && Tab.PegaPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return mat;
        }
        public override string ToString()
        {
            return "D";
        }
    }
}
