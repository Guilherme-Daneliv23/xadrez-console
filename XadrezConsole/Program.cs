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
                    try
                    {
                        Console.Clear();



                        Tela.imprimirPartida(part);


                        Console.WriteLine();
                        Console.Write("Send the origin position: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        part.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = part.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(part.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Send the destiny position: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        part.validarPosicaoDeDestino(origem, destino);

                        part.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }
                    
                }

                Console.Clear();
                Tela.imprimirPartida(part);

                
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex);
            }


        }
    }
}