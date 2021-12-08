using Abyat.Tournament.Players;

namespace Abyat.Tournament.Position
{
    public class Field : IPosition
    {
        public int GetPoints(Player player)
        {
            var handBallPlayer = player as HandBallPlayer;
            return 20 + handBallPlayer.GoalsMade - handBallPlayer.GoalsReceived;
        }
    }

}
