using System;
using System.Linq;
using System.Collections.Generic;

namespace BoardGameTracker.Models
{
    public class BoardGame
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImgScr {
            get { return (new string(Name.Where(char.IsLetterOrDigit).ToArray()))+".png"; }
        }
        public int PlayTime { get; set; }
        public int YearPublished { get; set; }
        public string Type { get; set; }
        public List<string> Designers { get; set; }
        public List<string> Mechanics { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }

    }

    public class BoardGameDBContext
    {
        private static List<BoardGame> _boardGames = new List<BoardGame>()
        {
            new BoardGame()
            {
                ID = 0,
                Name = "Coup",
                PlayTime = 15,
                YearPublished = 2012,
                Type =  "Party",
                Designers = new List<string>() { "Rikki Tahta" },
                Mechanics = new List<string>() { "Memory", "Player Elimination", "Deception" },
                MinPlayers = 2,
                MaxPlayers = 6
            },
            new BoardGame()
            {
                ID = 1,
                Name = "Dominion",
                PlayTime = 30,
                YearPublished = 2008,
                Type =  "Strategy",
                Designers = new List<string>() { "Donald X. Vaccarino" },
                Mechanics = new List<string>() { "Card Drafting", "Deck/Pool Building", "Hand Management" },
                MinPlayers = 2,
                MaxPlayers = 4
            },
            new BoardGame()
            {
                ID = 2,
                Name = "King of Tokyo",
                PlayTime = 30,
                YearPublished = 2011,
                Type = "Family",
                Designers = new List<string>() { "Richard Garfield" },
                Mechanics = new List<string>() { "Press Your Luck", "Dice Rolling", "Player Elimination" },
                MinPlayers = 2,
                MaxPlayers = 6
            },
            new BoardGame()
            {
                ID = 3,
                Name = "Machi Koro",
                PlayTime = 30,
                YearPublished = 2012,
                Type = "Family",
                Designers = new List<string>() { "Masao Suganuma" },
                Mechanics = new List<string>() { "Card Drafting", "Dice Rolling" },
                MinPlayers = 2,
                MaxPlayers = 4
            },
            new BoardGame()
            {
                ID = 4,
                Name = "Power Grid",
                PlayTime = 120,
                YearPublished = 2004,
                Type = "Strategy",
                Designers = new List<string>() { "Friedemann Friese" },
                Mechanics = new List<string>() { "Auction/Bidding", "Route/Network Building", "Resource Managment" },
                MinPlayers = 2,
                MaxPlayers = 6
            },
            new BoardGame()
            {
                ID = 5,
                Name = "Revolution!",
                PlayTime = 60,
                YearPublished = 2009,
                Designers = new List<string>() { "Philip duBarry" },
                Type = "Strategy",
                Mechanics = new List<string>() { "Aution/Bidding", "Simultaneous Action" },
                MinPlayers = 3,
                MaxPlayers = 4
            },
            new BoardGame()
            {
                ID = 6,
                Name = "Summoner Wars: Master Set",
                PlayTime = 30,
                YearPublished = 2011,
                Designers = new List<string>() { "Colby Dauch" },
                Type = "Strategy",
                Mechanics = new List<string>() { "Hand Management", "Grid Movement" },
                MinPlayers = 2,
                MaxPlayers = 4
            },
            new BoardGame()
            {
                ID = 7,
                Name = "The Settlers Of Catan",
                PlayTime = 60,
                YearPublished = 1995,
                Designers = new List<string>() { "Klaus Teuber" },
                Type = "Strategy",
                Mechanics = new List<string>() { "Resource Management", "Dice Rolling", "Route/Network Building", "Generative Board" },
                MinPlayers = 2,
                MaxPlayers = 4
            },
            new BoardGame()
            {
                ID = 8,
                Name = "Time Barons",
                PlayTime = 30,
                YearPublished = 2014,
                Designers = new List<string>() { "Jon Perry", "Derek Yu" },
                Type = "Strategy",
                Mechanics = new List<string>() { "Action Point System", "Hand Management" },
                MinPlayers = 2,
                MaxPlayers = 4
            },
            new BoardGame()
            {
                ID = 9,
                Name = "Zombie Dice",
                PlayTime = 15,
                YearPublished = 1995,
                Designers = new List<string>() { "Steve Jackson" },
                Type = "Party",
                Mechanics = new List<string>() { "Press Your Luck", "Dice Rolling" },
                MinPlayers = 2,
                MaxPlayers = 8
            }

        };
        public static List<BoardGame> BoardGames {
            get { return _boardGames; }
        }
    }
}