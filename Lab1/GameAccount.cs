using System;
using System.Collections.Generic;

namespace Lab1
{
    public class GameAccount
    {
        private List<Game> _chronicle = new List<Game>();
        private string _userName;
        private static int _gamesCount;
        private int _currentRating;

        public GameAccount(string player, int currentRating)
        {
            _userName = player;
            if (currentRating <= 1)
            {
                Console.WriteLine("!!!One or more players have a rating below 1!!!");
            }
            _currentRating = currentRating;
        }

        public void WinGame(GameAccount opponent, int rating)
        {
            if (rating > 0)
            {
                this._currentRating += rating;
                opponent._currentRating -= rating;
                if (opponent._currentRating <= 1)
                {
                    Console.WriteLine("!!!One or more players have a rating below 1!!!");
                }
                _chronicle.Add(new Game((++_gamesCount), opponent, "Win", rating, _currentRating));
            }
            else
            {
                Console.WriteLine("!Rating rate less than 0!");
            }
        }

        public void LoseGame(GameAccount opponent, int rating)
        {
            if (rating > 0)
            {
                this._currentRating -= rating;
                opponent._currentRating += rating;
                if (this._currentRating <= 1)
                {
                    Console.WriteLine("!!!One or more players have a rating below 1!!!");
                }
                _chronicle.Add(new Game((++_gamesCount), opponent, "Lose", rating, _currentRating));
            }
            else
            {
                Console.WriteLine("!Rating rate less than 0!");
            }
            
        }

        public void GetStats()
        {
            for (int i = 0; i < _chronicle.Count; i++)
            {
                Console.WriteLine("\nGame number " + _chronicle[i].GamesCount + ":");
                Console.WriteLine("ID of the Game: " + _chronicle[i].Gameid);
                Console.WriteLine("User " + _userName + " played against " + _chronicle[i].Opponent._userName);
                Console.WriteLine("The players play for the rating: " + _chronicle[i].Rating);
                Console.WriteLine("Result for user is: " + _chronicle[i].Result);
                Console.WriteLine(_userName+"'s current rating after game: " + _chronicle[i].CurrentRating);
                Console.WriteLine(_chronicle[i].Opponent._userName + "'s current rating after game: " + _chronicle[i].Opponent._currentRating);
            }
        }
    }
}