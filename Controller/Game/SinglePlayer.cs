using CSE = CShipsBattles.Enums;
using System;
using CShipsBattles.Model;

namespace CShipsBattles.Controller.Game
{
    public struct SinglePlayer : IGame
    {
        public void Game(Model.Ocean ocean, Model.Ocean oceanEnemy, 
                         Model.Player player, Model.Player enemy)
        {
            CSE.Ship shi = CSE.Ship.Battleship;
           
            oceanEnemy.printOcean();
            
        }

        
    }
}