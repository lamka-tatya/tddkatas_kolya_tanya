namespace TddKatas.TicToc
{
    public class Game
    {
        private Space _space;
        
        public Game()
        {
            _space = new Space();
        }
        public Space GetSpace()
        {
            return _space;
        }

        public void PlayRound(X x, Y y)
        {
            var coordinate = new Coordinate(x,y);
            _space = new Space(new[] {coordinate });
        }
    }
}