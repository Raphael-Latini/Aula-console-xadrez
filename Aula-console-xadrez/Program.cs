using System;
using tabuleiro;
using Xadrez;

namespace Aula_console_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab,posicoesPossiveis);



                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);


                }

                Console.ReadLine();
            }
            catch(TabuleiroExceptions e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
