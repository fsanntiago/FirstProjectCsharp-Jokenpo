namespace Jokenpo
{
    class Jogador
    {
        private int _jogada;
        public string Nome { get; set; }

        public int Jogada
        {
            get
            {
                return _jogada;
            }
            set
            {
                switch (value)
                {
                    // [1] - Pedra  [2] - Papel  [3] - Tesoura
                    case 1:
                        _jogada = 1;
                        break;
                    case 2:
                        _jogada = 2;
                        break;
                    case 3:
                        _jogada = 3;
                        break;
                    default:
                        return;

                }
            }
        }
    }
}
