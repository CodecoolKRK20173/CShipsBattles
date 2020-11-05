namespace CShipsBattles.Controller.Game
{
    public struct SinglePlayer : IGame
    {
        public void Game(Model.Ocean ocean, Model.Ocean oceanEnemy, 
                         Model.Player player, Model.Player enemy)
        {
            
            oceanEnemy.printOcean();
            
        }
    }
}