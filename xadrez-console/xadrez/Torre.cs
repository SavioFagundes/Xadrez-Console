using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez_console.tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "T";
        }
        public bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.Cor != Cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            pos.definirValores(Posicao.linha - 1,Posicao.coluna);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).Cor  != Cor)
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }
            pos.definirValores(Posicao.linha + 1, Posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }
            pos.definirValores(Posicao.linha, Posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }
            pos.definirValores(Posicao.linha, Posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.linha = pos.coluna - 1;
            }

            return mat;
        }
    }
}
