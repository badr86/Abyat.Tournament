using Abyat.Tournament.Players;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Abyat.Tournament.Tournments
{
    public class Match : IValidatableObject
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }

        public void CalcMatchResults(Dictionary<string, int> leaderBoard)
        {
            foreach (Player player in Team1.Players)
            {
                var points = player.CalcPoints();
                if (Team1.IsWinner)
                    points += 10;

                if (leaderBoard.ContainsKey(player.NickName))
                {
                    leaderBoard[player.NickName] += points;
                }
                else
                {
                    leaderBoard.Add(player.NickName, points);
                }
            }
            foreach (Player player in Team2.Players)
            {
                var points = player.CalcPoints();
                if (Team2.IsWinner)
                    points += 10;

                if (leaderBoard.ContainsKey(player.NickName))
                {
                    leaderBoard[player.NickName] += points;
                }
                else
                {
                    leaderBoard.Add(player.NickName, points);
                }
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Team1.IsWinner == Team2.IsWinner)
                    yield return new ValidationResult("Match must has one winner");

            var duplicatedNickNames = from p in Team1.Players.Union(Team2.Players)
                                          group p by p.NickName into g
                                          where g.Count() > 1
                                          select g.Key;
            if (duplicatedNickNames.Count() != 0)
                    yield return new ValidationResult("Player must play in one team in the same match");

        }
    }
}
