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
                Console.Write(8 - i + " ");
                for (int j = 0; j < Tab.colunas; j++)
                {   if(Tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }else
                    {
                        imprimePeca(Tab.peca(i, j));
                        Console.Write(" ");
                    }  
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimePeca(Peca peca)
        {
            if(peca.cor == Cor.Branca) 
            {
                Console.Write(peca);
            }else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
