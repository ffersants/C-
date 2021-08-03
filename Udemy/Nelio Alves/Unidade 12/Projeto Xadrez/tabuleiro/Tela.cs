﻿using System;

namespace tabuleiro
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int linha = 0; linha < tab.linhas; linha++)
            {
                for(int coluna = 0; coluna < tab.colunas; coluna++)
                {
                    if(tab.peca(linha, coluna) == null)
                    {
                        Console.Write("-" + " ");
                    }
                    else
                    {
                        Console.Write(tab.peca(linha, coluna) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
