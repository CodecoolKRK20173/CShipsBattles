using CShipsBattles.Model;

namespace CShipsBattles.Controller.Game
{
    public interface IGame
    {
        void Game(Ocean ocean, Ocean oceanEnemy, Player player, Player enemy);
    }
}