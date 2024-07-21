using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;

namespace tabuleiro
{
     abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            this.tab = tab;
            qteMovimentos = 0;
        }
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
        public abstract bool[,] MovimentosPossiveis();
        
    }
}
