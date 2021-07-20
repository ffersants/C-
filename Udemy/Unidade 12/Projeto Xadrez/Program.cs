using System;
using tabuleiro;
using xadrez;
namespace Projeto_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab;

            tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(tab, Cor.Amarelo), new Posicao(0, 5));
            Tela.imprimirTabuleiro(tab);
        }
    }
}
