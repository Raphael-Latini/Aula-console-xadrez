﻿

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int quantidadeMovimento { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca( Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.quantidadeMovimento = 0;
        }
        public void incrementarQtdDeMovimento()
        {
            quantidadeMovimento++;
        }
        public abstract bool[,] movimentosPossiveis();
    
    }
}
