namespace CShipsBattles.Model
{
    public struct Ship
    {
        private byte size;
        private string look;

        public Ship(byte size, string look)
        {
            this.size = size;
            this.look = look;
        }

        public byte Size
        {
            get => size;
            set => size = value;
        }

        public string Look
        {
            get => look;
            set => look = value;
        }
    }
}