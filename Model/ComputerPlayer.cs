namespace CShipsBattles.Model
{
    public class ComputerPlayer : Player, Controller.PlayerController.IPlayerController
    {
        public ComputerPlayer(string name, int points, int lives) : base(name, points, lives)
        {
            this.Name = "Computer";
        }

        public void PlaceShip(Ship ship, Ocean ocan)
        {
            
        }

        public bool Shoot(Ocean ocean)
        {
            return false;
        }
    }
}