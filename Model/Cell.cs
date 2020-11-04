namespace CShipsBattles.Model
{
    public struct Cell
    {
        private string look;

        public Cell(string look)
        {
            this.look = look;
        }

        public string Look
        {
            get => look;
            set => look = value;
        }
    }
}