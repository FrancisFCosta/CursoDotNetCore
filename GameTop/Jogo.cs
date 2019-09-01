using System;
using GameTop.Interface;

namespace GameTop
{
    public class Jogo
    {
        public IJogador _Jogador { get; }

        public Jogo(IJogador Jogador)
        {
            _Jogador = Jogador;
        }

        public void iniciarJogo()
        {
            Console.WriteLine(_Jogador.Chuta());
            Console.WriteLine(_Jogador.Corre());
            Console.WriteLine(_Jogador.Passe());
        }
    }
}