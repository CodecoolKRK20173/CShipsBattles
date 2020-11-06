namespace CShipsBattles.Model
{
    public struct Coordinates
    {
        private int x;
        private int y;
        /*public (int x, int y) position;*/
        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }
    }
}