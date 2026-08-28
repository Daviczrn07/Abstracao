using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao
{
    internal class Time
    {
        public string NomeTime;
        public List<Jogador> ListaDeJogadores = new List<Jogador>();

        public void AdicionarJogador(Jogador jogador)
        {
            ListaDeJogadores.Add(jogador);
        }

        public void ListarJogadores()
        {
            Console.WriteLine($"Time: {NomeTime}");
            Console.WriteLine("Escalação:");

            foreach (Jogador jogador in ListaDeJogadores)
            {
                Console.WriteLine($"Camisa {jogador.NumeroCamisa}-{jogador.Nome}-{jogador.Posicao}");
            }

        }
    }
}
