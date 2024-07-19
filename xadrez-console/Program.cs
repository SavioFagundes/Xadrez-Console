using tabuleiro;
using xadrez;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(3, 5));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(5, 4));
            Tela.imprimirTabuleiro(tab);
        }
    }
}