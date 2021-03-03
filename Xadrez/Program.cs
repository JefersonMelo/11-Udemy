using System;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.ColocarPeca(new Rei(tab, Cor.Preto), new Posicao(0, 0));
            tab.ColocarPeca(new Rei(tab, Cor.Branco), new Posicao(0, 1));
            Tela.ImprimirTabuleiro(tab);

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());
        }
    }
}
