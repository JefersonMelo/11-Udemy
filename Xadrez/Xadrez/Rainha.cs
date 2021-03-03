namespace Xadrez
{
    class Rainha : Peca
    {
        public Rainha(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            //Retorna D-Dama por R ser do Rei
            return "D";
        }
    }
}
