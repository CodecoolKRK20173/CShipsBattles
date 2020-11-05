namespace CShipsBattles.Model
{
    public class Player
    {
        private string name;
        private byte points;
        private sbyte lives;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public byte Points
        {
            get => points;
            set => points = value;
        }

        public sbyte Lives
        {
            get => lives;
            set => lives = value;
        }

        public Player()
        {
            this.Name = "DefaultName";
            this.Points = 0;
            this.Lives = 0;
        }

        public Player(string name, byte points, sbyte lives)
        {
            this.name = name;
            this.points = points;
            this.lives = lives;
        }
    }
}