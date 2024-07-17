using tabuleiro;
using xadrez;
using System.Collections.Generic;

namespace XadrezConsole
{
    class Tela
    {   
        public static void imprimirPartida(PartidaDeXadrez partida)
        {
            Console.WriteLine("XADREZ CONSOLE!");
            Console.WriteLine();
            imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            imprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turn: " + partida.turno);

            if(!partida.terminada)
            {
                Console.Write("Waiting for move: ");
                if (partida.jogadorAtual == Cor.Preta)
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(partida.jogadorAtual);
                    Console.ForegroundColor = aux;
                }
                else
                {
                    Console.WriteLine(partida.jogadorAtual);
                }
                
                if (partida.xeque)
                {
                    Console.WriteLine("XEQUE!!!");
                }
            }
            else
            {
                Console.WriteLine("XEQUEMATE!");
                Console.WriteLine("Winner: " + partida.jogadorAtual);
            }
            
        }

        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Captured pieces: ");
            Console.Write("White: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Black: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach(Peca x in conjunto)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }


        public static void imprimirTabuleiro(Tabuleiro Tab)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < Tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < Tab.colunas; j++)
                {
                    Console.ForegroundColor = aux;
                    imprimePeca(Tab.peca(i, j));  
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            
            Console.WriteLine("  a b c d e f g h");
            Console.ForegroundColor = aux;
        }

        public static void imprimirTabuleiro(Tabuleiro Tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkCyan;


            for (int i = 0; i < Tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < Tab.colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    
                    imprimePeca(Tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
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
            if(peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }

            
        }
    }
}
