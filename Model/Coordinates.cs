namespace CShipsBattles.Model
{
    public struct Coordinates
    {
        private byte x;
        private byte y;

        public Coordinates(byte x, byte y)
        {
            this.x = x;
            this.y = y;
        }

        public byte X
        {
            get => x;
            set => x = value;
        }

        public byte Y
        {
            get => y;
            set => y = value;
        }
    }
}