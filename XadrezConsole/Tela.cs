using System;
using tabuleiro;
using xadrez;

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

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");

            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimePeca(Peca peca)
        {
            if(peca.cor == Cor.Branca) 
            {
                Console.Write(peca);
            }else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
