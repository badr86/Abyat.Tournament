using Abyat.Tournament.Sport;
using System.Collections.Generic;
using System.Linq;

namespace Abyat.Tournament.Tournments
{
    public class Tournment
    {
        public ISport Sport { get; set; }
        public int Year { get; set; }
        public List<Match> Matches { get; set; }
        public Dictionary<string, int> LeaderBoard { get; set; }
        public Tournment()
        {
            LeaderBoard = new Dictionary<string, int>();
        }

        public KeyValuePair<string,int> MostValuablePlayer()
        {
            foreach (Match match in Matches)
            {
                match.CalcMatchResults(LeaderBoard);
            }
            var first = LeaderBoard.OrderByDescending(kv => kv.Value).FirstOrDefault();
            return first;
        }
    }
}
