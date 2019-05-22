namespace TddKatas.TicToc
{
    public struct Coordinate
    {
        public readonly X X;
        
        public readonly Y Y;

        public Coordinate(X x, Y y)
        {
            X = x;
            Y = y;
        }
    }

    public struct X
    {
        public readonly int Value;

        public X(int value)
        {
            Value = value;
        }
    }
    
    public struct Y
    {
        public readonly int Value;

        public Y(int value)
        {
            Value = value;
        }
    }
}