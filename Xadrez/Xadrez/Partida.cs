namespace Xadrez
{
    class Partida
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool Terminada { get; private set; }

        public Partida()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branco;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementarMovimento();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        public void ColocarPecas()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('c', 1).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('c', 2).ToPosicao());

            tab.ColocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('c', 7).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('c', 8).ToPosicao());


        }
    }
}
