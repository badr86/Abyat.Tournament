using Abyat.Tournament.Players;

namespace Abyat.Tournament.Position
{
    public class Goalkeeper : IPosition
    {
        public int GetPoints(Player player)
        {
            var handBallPlayer = player as HandBallPlayer;
            return 50 + (handBallPlayer.GoalsMade * 5) - (handBallPlayer.GoalsReceived * 2);
        }
    }

}
