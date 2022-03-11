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
                
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(2, 4));
                tab.colocarPeca(new Rei(tab, Cor.Azul), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Azul), new Posicao(0, 5));
                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch(TabuleiroExceptions e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
