using System;
using tabuleiro;
using xadrez;


namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez part = new PartidaDeXadrez();

                while (!part.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(part.tab);

                    Console.WriteLine();
                    Console.Write("Send the origin position: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Send the destiny position: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    part.executaMovimento(origem, destino);

                }

                
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex);
            }

            /*PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos.toPosicao());*/


        }
    }
}