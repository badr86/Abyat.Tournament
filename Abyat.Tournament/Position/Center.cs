using Abyat.Tournament.Players;

namespace Abyat.Tournament.Position
{
    public class Center : IPosition
    {
        public int GetPoints(Player player)
        {
            var basketPlayer = player as BasketBallPlayer;
            return (basketPlayer.ScoredPoints * 2) + (basketPlayer.Rebounds * 1) + (basketPlayer.Assists * 3);
        }
    }

}
