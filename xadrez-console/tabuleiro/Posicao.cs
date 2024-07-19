using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Posicao
    {

        public int Linhas { get; set; }
        public int Colunas { get; set; }

        public Posicao(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
        }
    }
}
