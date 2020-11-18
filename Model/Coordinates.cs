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

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == ((Coordinates)obj).GetHashCode();
        }

        public override int GetHashCode()
        {
            return (this.X *7 + this.Y *3).GetHashCode();
        }
    }
}