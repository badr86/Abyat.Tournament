using Abyat.Tournament.Players;

namespace Abyat.Tournament.Position
{
    public class Forward : IPosition
    {
        public int GetPoints(Player player)
        {
            var basketPlayer = player as BasketBallPlayer;
            return (basketPlayer.ScoredPoints * 2) + (basketPlayer.Rebounds * 2) + (basketPlayer.Assists * 2);
        }
    }

}
