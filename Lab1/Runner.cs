namespace Lab1
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            GameAccount player1 = new GameAccount("Ivan", 5000);
            GameAccount player2 = new GameAccount("Nazar", 5000);
            GameAccount player3 = new GameAccount("Ekaterina", 5000);
            GameAccount player4 = new GameAccount("Oleksandr", 5000);
            GameAccount player5 = new GameAccount("Alina", 5000);
            player1.WinGame(player2, 500);
            player1.WinGame(player3, 200);
            player4.LoseGame(player5, 3000);
            player1.GetStats();
            player4.GetStats();
        }
    }
}