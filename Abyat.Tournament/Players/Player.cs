using Abyat.Tournament.Position;

namespace Abyat.Tournament.Players
{
    public abstract class Player 
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public int Number { get; set; }
        public string Team { get; set; }
        public IPosition Position { get; set; }
        public  int CalcPoints()
        {
            return Position.GetPoints(this);
        }
    }
}
