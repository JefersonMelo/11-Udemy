using System;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tabuleiro tab = new Tabuleiro(8, 8);

            //Tela.ImprimirTabuleiro(tab);

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());
        }
    }
}
