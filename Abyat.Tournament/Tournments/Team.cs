using Abyat.Tournament.Players;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Abyat.Tournament.Tournments
{
    public class Team : IValidatableObject
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public bool IsWinner { get; set; }

        public Player GetMostValuablePlayer()
        {
            var player = Players.Aggregate((p1, p2) => p1.CalcPoints() > p2.CalcPoints() ? p1 : p2);
            return player;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var duplicatedNickNames = from p in Players
                                group p by p.NickName into g
                                where g.Count() > 1
                                select g.Key;
            if (duplicatedNickNames.Count() != 0)
                yield return new ValidationResult("Duplicate player in the team");
        }
    }
}
