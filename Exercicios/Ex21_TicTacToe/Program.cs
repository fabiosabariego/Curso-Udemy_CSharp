namespace Ex21_TicTacToe
{
    public class Program
    {
        // Declarando a Matriz 2D
        static string[,] board =
        {
            {"X", "2", "3"},
            {"X", "5", "6"},
            {"X", "8", "9"}
        };

        static void Main(string[] args)
        {
            bool checkWinner = Checker(board);

            // Verificando se existem vencedores
            if(checkWinner == true)
            {
                Console.WriteLine("Existe um Ganhador!!!");
            }
            else
            {
                Console.WriteLine("Nao Existem Ganhadores!!!");
            }

        }

        public static bool Checker(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                // Verificando as Linhas e Colunas
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i,2])
                {
                    return true;
                }
                if (board[0,i] == board[1,i] && board[1,i] == board[2, i])
                {
                    return true;
                }

            }
            // Verificando as diagonais
            if (board[0,0] == board[1,1] && board[1,1] == board[2,2])
            {
                return true;
            }
            if (board[0,2] == board[1,1] && board[1,1] == board[2,0])
            {
                return true;
            }

            return false;
        }
    }
}