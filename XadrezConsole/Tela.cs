using System;
using tabuleiro;

namespace XadrezConsole
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro Tab)
        {
            for (int i = 0; i < Tab.linhas; i++)
            {
                for(int j = 0; j < Tab.colunas; j++)
                {   if(Tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }else
                    {
                        Console.Write(Tab.peca(i, j) + " ");
                    }  
                }
                Console.WriteLine();
            }
        }
    }
}
