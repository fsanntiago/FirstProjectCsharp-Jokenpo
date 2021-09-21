using System;

namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador player1 = new Jogador();
            Jogador player2 = new Jogador();
            Juiz juiz = new Juiz();
            bool win = false;
            int rounds = 1;
            ConsoleKeyInfo consoleKey;

            Console.WriteLine("################ Jokenpo ################");
            Console.WriteLine("-> Regras: ");
            Console.WriteLine(". Papel empata com Papel e ganha de Pedra Pedra empata com Pedra e ganha de Tesoura");
            Console.WriteLine(". Tesoura empata com Tesoura e ganha de Papel");
            Console.WriteLine(". Papel empata com Papel e ganha de Pedra");
            Console.WriteLine();

            Console.WriteLine("Digite o nome do 1° jogador: ");
            player1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do 2° jogador: ");
            player2.Nome = Console.ReadLine();

            while (!win)
            {
                Console.WriteLine(rounds + "° Round");

                Console.WriteLine("Vez do(a) " + player1.Nome);
                Console.WriteLine("[1] - Pedra    [2] - Papel    [3] - Tesoura");
                player1.Jogada = int.Parse(Console.ReadLine());

                Console.WriteLine("Vez do(a) " + player2.Nome);
                Console.WriteLine("[1] - Pedra    [2] - Papel    [3] - Tesoura");
                player2.Jogada = int.Parse(Console.ReadLine());

                Console.WriteLine("-Juiz: " + juiz.Analisar(player1, player2));
                Console.WriteLine();
                bool resultadoPartida = juiz.getResultado();
                if (resultadoPartida)
                {
                    Console.WriteLine("Prescione <Enter> para jogar novamente");
                    Console.WriteLine("Prescione <Esc> para sair");
                    consoleKey = Console.ReadKey();
                    if (consoleKey.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                    if (consoleKey.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        continue;
                    }
                }
                win = resultadoPartida;
                rounds++;
                Console.WriteLine();
            }


        }
    }
}
