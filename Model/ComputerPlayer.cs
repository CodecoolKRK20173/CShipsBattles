namespace CShipsBattles.Model
{
    public class ComputerPlayer : Player, Controller.PlayerController.IPlayerController
    {
        public ComputerPlayer(string name, byte points, sbyte lives) : base(name, points, lives)
        {
            this.Name = "Computer";
        }

        public void PlaceShip(Ship ship, Ocean ocan)
        {
            
        }

        public bool _shoot(Ocean ocean)
        {
            return false;
        }
    }
}