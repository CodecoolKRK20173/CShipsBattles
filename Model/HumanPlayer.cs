namespace CShipsBattles.Model
{
    public class HumanPlayer : Player, Controller.PlayerController.IPlayerController
    {
        public HumanPlayer(string name, byte points, sbyte lives) : base(name, points, lives)
        {
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