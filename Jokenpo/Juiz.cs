namespace Jokenpo
{
    class Juiz
    {
        private bool resultado;

        public string Analisar(Jogador player1, Jogador player2)
        {
            // [1] - Pedra  [2] - Papel  [3] -

            if (player1.Jogada == player2.Jogada)
            {
                resultado = false;
                return "Empatou! Novo Round!!";
            }
            else if ((player1.Jogada == 1 && player2.Jogada == 2) || (player1.Jogada == 2 && player2.Jogada == 3))
            {
                resultado = true;
                return player2.Nome + " ganhou!!";
            }
            else
            {
                resultado = true;
                return player1.Nome + " ganhou!!";

            }
        }

        public bool getResultado()
        {
            return resultado;
        }
    }
}
