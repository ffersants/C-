using System;
using tabuleiro;

namespace Projeto_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab;

            tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);
        }
    }
}
