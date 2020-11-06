namespace CShipsBattles.Controller.Game
{
    public interface IGame
    {
        void Game(ref Model.Ocean ocean, ref Model.Ocean oceanEnemy, ref Model.Player player, ref Model.Player enemy);
    }
}