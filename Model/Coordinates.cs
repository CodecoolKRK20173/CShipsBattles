namespace CShipsBattles.Model
{
    public struct Coordinates
    {
        public int X { get; set;}
        public int Y { get; set;}
        /*public (int x, int y) position;*/
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}