using System;
using tabuleiro;
using xadrez_console.tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab,cor)
        {
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
