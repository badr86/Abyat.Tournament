using Abyat.Tournament.Players;
using Abyat.Tournament.Position;
using Abyat.Tournament.Tournments;
using System;
using System.Collections.Generic;

namespace Abyat.Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tournment handBallTournment = new Tournment
            {
                Matches = new List<Match>
                {
                new Match
                {
                    Team1 = new Team
                    {
                        Name = "A",
                        Players = new List<Player> {
                        new HandBallPlayer { Name = "Player1", NickName = "Nick1", GoalsMade = 0, GoalsReceived = 20, Position = new Goalkeeper() },
                        new HandBallPlayer { Name = "Player2", NickName = "Nick2", GoalsMade = 15, GoalsReceived = 20, Position = new Field() },
                        new HandBallPlayer { Name = "Player3", NickName = "Nick3", GoalsMade = 10, GoalsReceived = 20, Position = new Field() },
                        },
                        IsWinner = true
                    },
                    Team2 = new Team {
                        Name = "B",
                        Players = new List<Player> {
                        new HandBallPlayer { Name = "Player4", NickName = "Nick4", GoalsMade = 1, GoalsReceived = 25, Position = new Goalkeeper() },
                        new HandBallPlayer { Name = "Player5", NickName = "Nick5", GoalsMade = 12, GoalsReceived = 25, Position = new Field() },
                        new HandBallPlayer { Name = "Player6", NickName = "Nick6", GoalsMade = 8, GoalsReceived = 25, Position = new Field() },
                    } 
                    }
                },
                new Match
                {
                    Team1 = new Team
                    {
                        Name = "A",
                        Players = new List<Player> {
                        new HandBallPlayer { Name = "Player1", NickName = "Nick1", GoalsMade = 2, GoalsReceived = 15, Position = new Goalkeeper() },
                        new HandBallPlayer { Name = "Player2", NickName = "Nick2", GoalsMade = 10, GoalsReceived = 15, Position = new Field() },
                        new HandBallPlayer { Name = "Player3", NickName = "Nick3", GoalsMade = 5, GoalsReceived = 15, Position = new Field() },
                        },
                        IsWinner = true
                    },
                    Team2 = new Team {
                        Name = "C",
                        Players = new List<Player> {
                        new HandBallPlayer { Name = "Player7", NickName = "Nick7", GoalsMade = 1, GoalsReceived = 19, Position = new Goalkeeper() },
                        new HandBallPlayer { Name = "Player8", NickName = "Nick8", GoalsMade = 6, GoalsReceived = 19, Position = new Field() },
                        new HandBallPlayer { Name = "Player9", NickName = "Nick9", GoalsMade = 3, GoalsReceived = 19, Position = new Field() },
                    }
                    }
                },
                new Match
                {
                    Team1 = new Team
                    {
                        Name = "C",
                        Players = new List<Player> {
                        new HandBallPlayer { Name = "Player7", NickName = "Nick7", GoalsMade = 3, GoalsReceived = 22, Position = new Goalkeeper() },
                        new HandBallPlayer { Name = "Player8", NickName = "Nick8", GoalsMade = 12, GoalsReceived = 22, Position = new Field() },
                        new HandBallPlayer { Name = "Player9", NickName = "Nick9", GoalsMade = 10, GoalsReceived = 22, Position = new Field() },
                        },
                        IsWinner = true
                    },
                    Team2 = new Team {
                        Name = "B",
                        Players = new List<Player> {
                        new HandBallPlayer { Name = "Player4", NickName = "Nick4", GoalsMade = 2, GoalsReceived = 25, Position = new Goalkeeper() },
                        new HandBallPlayer { Name = "Player5", NickName = "Nick5", GoalsMade = 10, GoalsReceived = 25, Position = new Field() },
                        new HandBallPlayer { Name = "Player6", NickName = "Nick6", GoalsMade = 10, GoalsReceived = 25, Position = new Field() },
                    }
                    }
                }
                }
            };

            Tournment basketBallTournment = new Tournment
            {
                Matches = new List<Match>
                {
                new Match
                {
                    Team1 = new Team
                    {
                        Name = "A",
                        Players = new List<Player> {
                        new BasketBallPlayer { Name = "Player1", NickName = "Nick1", ScoredPoints = 10, Rebounds = 2, Assists = 7, Position = new Guard() },
                        new BasketBallPlayer { Name = "Player2", NickName = "Nick2", ScoredPoints = 15, Rebounds = 20, Assists = 0, Position = new Forward() },
                        new BasketBallPlayer { Name = "Player3", NickName = "Nick3", ScoredPoints = 10, Rebounds = 20, Assists = 4, Position = new Center() },
                        },
                        IsWinner = true                    },
                    Team2 = new Team {
                        Name = "B",
                        Players = new List<Player> {
                        new BasketBallPlayer { Name = "Player4", NickName = "Nick4", ScoredPoints = 20, Rebounds = 0, Assists = 0, Position = new Guard() },
                        new BasketBallPlayer { Name = "Player5", NickName = "Nick5", ScoredPoints = 4, Rebounds = 7, Assists = 7, Position = new Forward() },
                        new BasketBallPlayer { Name = "Player6", NickName = "Nick6", ScoredPoints = 8, Rebounds = 10, Assists = 0, Position = new Center() },
                    }
                    }
                },
                new Match
                {
                    Team1 = new Team
                    {
                        Name = "A",
                        Players = new List<Player> {
                        new BasketBallPlayer { Name = "Player1", NickName = "Nick1", ScoredPoints = 10, Rebounds = 2, Assists = 7, Position = new Guard() },
                        new BasketBallPlayer { Name = "Player2", NickName = "Nick2", ScoredPoints = 15, Rebounds = 20, Assists = 0, Position = new Forward() },
                        new BasketBallPlayer { Name = "Player3", NickName = "Nick3", ScoredPoints = 10, Rebounds = 20, Assists = 4, Position = new Center() },
                        },
                        IsWinner = true
                    },
                    Team2 = new Team {
                        Name = "C",
                        Players = new List<Player> {
                        new BasketBallPlayer { Name = "Player7", NickName = "Nick7", ScoredPoints = 20, Rebounds = 0, Assists = 0, Position = new Guard() },
                        new BasketBallPlayer { Name = "Player8", NickName = "Nick8", ScoredPoints = 4, Rebounds = 7, Assists = 7, Position = new Forward() },
                        new BasketBallPlayer { Name = "Player9", NickName = "Nick9", ScoredPoints = 8, Rebounds = 10, Assists = 0, Position = new Center() },
                    }
                    }
                },
                new Match
                {
                    Team1 = new Team
                    {
                        Name = "C",
                        Players = new List<Player> {
                        new BasketBallPlayer { Name = "Player7", NickName = "Nick7", ScoredPoints = 10, Rebounds = 2, Assists = 7, Position = new Guard() },
                        new BasketBallPlayer { Name = "Player8", NickName = "Nick8", ScoredPoints = 15, Rebounds = 20, Assists = 0, Position = new Forward() },
                        new BasketBallPlayer { Name = "Player9", NickName = "Nick9", ScoredPoints = 10, Rebounds = 20, Assists = 4, Position = new Center() },
                        },
                        IsWinner = true
                    },
                    Team2 = new Team {
                        Name = "B",
                        Players = new List<Player> {
                        new BasketBallPlayer { Name = "Player4", NickName = "Nick4", ScoredPoints = 20, Rebounds = 0, Assists = 0, Position = new Guard() },
                        new BasketBallPlayer { Name = "Player5", NickName = "Nick5", ScoredPoints = 4, Rebounds = 7, Assists = 7, Position = new Forward() },
                        new BasketBallPlayer { Name = "Player6", NickName = "Nick6", ScoredPoints = 8, Rebounds = 10, Assists = 0, Position = new Center() },
                    }
                    }
                },
                }
                
            };

            var mostValuableHandBallPlayer = handBallTournment.MostValuablePlayer();
            Console.WriteLine(mostValuableHandBallPlayer.Key, mostValuableHandBallPlayer.Value);

            var mostValuableBasketBallPlayer = basketBallTournment.MostValuablePlayer();
            Console.WriteLine(mostValuableBasketBallPlayer.Key, mostValuableBasketBallPlayer.Value);
        }
    }
}
