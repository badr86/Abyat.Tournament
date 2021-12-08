using Abyat.Tournament.Players;

namespace Abyat.Tournament.Position
{
    public class Guard : IPosition
    {
        public int GetPoints(Player player)
        {
            var basketPlayer = player as BasketBallPlayer;
            return (basketPlayer.ScoredPoints * 2) + (basketPlayer.Rebounds * 3) + (basketPlayer.Assists * 1);  
        }
    }

}
