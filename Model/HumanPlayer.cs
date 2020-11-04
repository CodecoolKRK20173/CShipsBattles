namespace CShipsBattles.Model
{
    public class HumanPlayer : Player, Controller.PlayerController.IPlayerController
    {
        public HumanPlayer(string name, int points, int lives) : base(name, points, lives)
        {
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