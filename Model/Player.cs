namespace CShipsBattles.Model
{
    public class Player
    {
        private string name;
        private int points;
        private int lives;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Points
        {
            get => points;
            set => points = value;
        }

        public int Lives
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

        public Player(string name, int points, int lives)
        {
            this.name = name;
            this.points = points;
            this.lives = lives;
        }
    }
}