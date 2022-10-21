using System;

namespace Lab1
{
    public class Game
    {
        public int GamesCount;
        public GameAccount Opponent;
        public string Result;
        public int Rating; 
        public int CurrentRating; 
        public string Gameid;
        

        public Game(int gamesCount, GameAccount opponent, string result, int userRating, int opponentRating)
        {
            Opponent = opponent;
            Result = result;
            GamesCount = gamesCount;
            Rating = userRating;
            CurrentRating = opponentRating;
            Guid gameId = Guid.NewGuid();
            Gameid = gameId.ToString();
        }
    }
}