using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez_console.tabuleiro;
using xadrez;

namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branco;
            ColocarPeca();
            terminada = false;
        }
        public void executaMovimentos(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimentos(origem, destino);
            Turno++;
            mudaJogador();
        }

        public void validarPosicaoDeOrigem(Posicao pos)
        {
            if(tab.peca(pos) == null)
            {
                throw new TabuleiroExceptions("Não existe peça na posição de origem escolhida");
            }
            if(JogadorAtual != tab.peca(pos).Cor)
            {
                throw new TabuleiroExceptions("A peça de origem escolhida não é sua");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroExceptions("Não há movimentos possíveis para a peça de origem escolhida");
            }
        }

        private void mudaJogador()
        {
            if(JogadorAtual == Cor.Branco)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branco;
            }
        }
        private void ColocarPeca()
        {
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(3, 5));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(5, 4));
            
        }
    }
    


    
}
