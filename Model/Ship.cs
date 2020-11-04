namespace CShipsBattles.Model
{
    public struct Ship
    {
        private int size;
        private string look;

        public Ship(int size, string look)
        {
            this.size = size;
            this.look = look;
        }

        public int Size
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