namespace Score_HighScore
{
    internal class Program
    {
        static int highScore = 300;
        static string highScorePlayer = "Denis";

        static void Main(string[] args)
        {
            //int newScore = 0;
            //string newPlayer;

            //Console.Write("Digite sua Pontuacao: ");
            //int.TryParse(Console.ReadLine(), out newScore);

            //Console.Write($"Digite seu Nome: ");
            //newPlayer = Console.ReadLine();

            GameScore(150, "Maria");
            GameScore(320, "Sergio");
            GameScore(310, "Fabio");
            GameScore(380, "Pablo");

        }

        public static void GameScore(int score, string playerName)
        {
            if (score > highScore)
            {
                highScore = score;
                highScorePlayer = playerName;
                Console.WriteLine($"Nova Pontuacao: {highScore}");
                Console.WriteLine($"Novo Jogador: {highScorePlayer} \n\n");
            }
            else
            {
                Console.WriteLine($"A antiga Pontuacao {highScore} nao pode ser quebrada e segue como lider {highScorePlayer}\n\n");
            }
        }
    }
}