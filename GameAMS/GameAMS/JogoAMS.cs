using GameAMS.Interface;
using System;

namespace GameAMS.Aplication
{
    public class JogoAMS
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;
        public JogoAMS(IJogador jogadorA,IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }

        public void IniciarJogo()
        {
            Console.WriteLine($"Jogo iniciado pelo jogador A \n{_jogadorA.Chutar()}");
            Console.WriteLine($"{_jogadorA.Correr()}");
            Console.WriteLine($"{_jogadorA.Passar()}");
            Console.WriteLine($"");
            Console.WriteLine($"Jogo iniciado pelo jogador B \n{_jogadorB.Chutar()}");
            Console.WriteLine($"{_jogadorB.Correr()}");
            Console.WriteLine($"{_jogadorB.Passar()}");
        }
    }
}