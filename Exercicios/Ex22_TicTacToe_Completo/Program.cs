namespace Ex22_TicTacToe_Completo
{
    internal class Program
    {
        static string[,] board =
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
        };

        static void Main(string[] args)
        {
            bool finalizaJogo = true;

            ColunasTabela();
            MontaGame(board);

            while (finalizaJogo == true)
            {
                for (int i = 1; i < 3; i++)
                {
                    bool verificaVencedor = Checker(board, i);

                    if (verificaVencedor == true)
                    {
                        Console.Write("Aperte ENTER para Jogar Novamente ou ESC para sair");
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            finalizaJogo = false;
                            i = 3; // Feito isso para que, quando o jogador resolva finalizar nao seja executado o for novamente
                        }
                        
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            Restart(board);
                            Console.Clear();
                            ColunasTabela();
                            MontaGame(board);
                        }
                    }
                    else
                    {
                        AlteraGame(board, i);
                    }
                    
                }
                
            }

        }

        //-----------------------------------------------------------------------
        // METODOS

        public static void ColunasTabela()
        {
            for (int i = 0; i < 7; i += 2)
            {
                for (int j = 5; j < 12; j += 6)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write("|");
                }
                
            }
            Console.SetCursorPosition(0, 1);
        }

        public static void MontaGame(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (j != 2)
                    {
                        Console.Write($"  {board[i, j]}  |");
                    }
                    else
                    {
                        Console.Write($"  {board[i, j]}  ");
                    }
                }
                Console.WriteLine("\n");
            }
        }

        public static void AlteraGame(string[,] board, int jogador)
        {
            string recebeJogada; // Recebe do Console qual sera a posicao que sera marcada  "X" ou "O" da jogada
            bool verificaJogada = true;

            while (verificaJogada == true)
            {
                Console.SetCursorPosition(0, 8);
                Console.Write($"Jogador {jogador} - Escolha um Campo: ");
                recebeJogada = Console.ReadLine();

                for (int j = 0; j < board.GetLength(0); j++)
                {
                    for (int k = 0; k < board.GetLength(1); k++)
                    {
                        if (recebeJogada.Equals(board[j, k]))
                        {
                            if (jogador == 1)
                            {
                                board[j, k] = "X";
                            }
                            else
                            {
                                board[j, k] = "O";
                            }
                            verificaJogada = false;
                        }
                    }
                }
                if (verificaJogada == true)
                {
                    Console.WriteLine("Campo Preenchido, Tente novamente!!!");
                }
                else
                {
                    Console.Clear();
                    ColunasTabela();
                    MontaGame(board);
                }
            }
        }

        public static bool Checker(string[,] board, int jogador)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                // Verifica vencedor nas linhas
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    if (board[i, 0] == "X")
                    {
                        Console.WriteLine("Parabéns Jogador 1, Você é o VENCEDOR!!!!!");
                        return true;
                    }
                    else if (board[i, 0] == "O")
                    {
                        Console.WriteLine("Parabéns Jogador 2, Você é o VENCEDOR!!!!!");
                        return true;
                    }
                }

                // Verifica vencedor nas colunas
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    if (board[0,i] == "X")
                    {
                        Console.WriteLine("Parabéns Jogador 1, Você é o VENCEDOR!!!!!");
                        return true;
                    }
                    else if (board[0,i] == "O")
                    {
                        Console.WriteLine("Parabéns Jogador 2, Você é o VENCEDOR!!!!!");
                        return true;
                    }
                }
            }

            // Verificando vencedor nas Diagonais
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                if (board[0, 0] == "X")
                {
                    Console.WriteLine("Parabéns Jogador 1, Você é o VENCEDOR!!!!!");
                    return true;
                }
                else if (board[0,0] == "O")
                {
                    Console.WriteLine("Parabéns Jogador 2, Você é o VENCEDOR!!!!!");
                    return true;
                }
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[0, 2] == "X")
                {
                    Console.WriteLine("Parabéns Jogador 1, Você é o VENCEDOR!!!!!");
                    return true;
                }
                else if (board[0, 2] == "O")
                {
                    Console.WriteLine("Parabéns Jogador 2, Você é o VENCEDOR!!!!!");
                    return true;
                }
            }
            return false;
        }

        public static void Restart(string[,] board)
        {
            int valorInicial = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    ++valorInicial;
                    board[i, j] = valorInicial.ToString();
                }
            }

        }
    }
}