namespace CShipsBattles.Controller.Game
{
    public interface IGame
    {
        void Game(Model.Ocean ocean, Model.Ocean oceanEnemy, Model.Player player, Model.Player enemy);
    }
}