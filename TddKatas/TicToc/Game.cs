namespace TddKatas.TicToc
{
    public class Game
    {
        private readonly Space _space;
        
        public Game()
        {
            _space = new Space();
        }
        public Space GetSpace()
        {
            return _space;
        }
    }
}