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
                    try {
                        Console.Clear();
                        Tela.imprimirPartida(partida);
                    Console.Write("origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoOrigem(origem);

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab,posicoesPossiveis);
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDestino(origem, destino);

                    partida.realizarJogada(origem, destino);

                    }
                    catch(TabuleiroExceptions e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine(); 
                    }

                }
                Console.Clear();
                Tela.imprimirPartida(partida);


                Console.ReadLine();
            }
            catch(TabuleiroExceptions e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
