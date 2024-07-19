using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linhas, pos.Colunas];
        }
        public bool existePeca(Posicao pos)
        {
            posicaoValida(pos);
            return peca(pos) != null;
        }


        public void colocarPeca(Peca p, Posicao pos)
        {
            if(existePeca(pos))
            {
                throw new TabuleiroExceptions("Já existe uma peça nessa posição");
            }
            pecas[pos.Linhas, pos.Colunas] = p;
            p.Posicao = pos;
        }
        public bool posicaoValida(Posicao pos)
        {
            if (pos.Linhas < 0 || pos.Linhas >= linhas || pos.Colunas < 0 || pos.Colunas >= colunas)
            {
                return false;
            }
            return true;
        }
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroExceptions("Posicao Inválida !");
            }
        }
    }
}
