using CSE = CShipsBattles.Enums;
using System;
using CShipsBattles.Helpers;
using CShipsBattles.Model;
using CShipsBattles.Model.ShipModel;

namespace CShipsBattles.Controller.Game
{
    public class SinglePlayer /*\\: IGame*/
    {
        Random random = new Random();

        public void Game(Ocean ocean, Ocean oceanEnemy,
                         Player player, Player enemy)
        {
            // oceanEnemy.printOcean();
           CoordinatesGenerated.coordGenerate();
                foreach (int i in Enum.GetValues(typeof(CSE.ShipNames)))
                {
                    CSE.ShipNames name = (CSE.ShipNames) i;
                    var coordinates = CoordinatesGenerated._coordinates[i];
                    var sh = ShipFactory.ship(name);
                    while (!Player.is_place_available(coordinates, sh, ocean) ||
                           !Player.is_place_in_range(coordinates, sh, ocean))
                   {
                          CoordinatesGenerated._coordinates.Clear();
                          CoordinatesGenerated.coordGenerate();
                          coordinates = CoordinatesGenerated._coordinates[i];
                   }
                    player.PlaceShip(coordinates, sh, ocean);
                }
                Console.WriteLine("Your board:");
                ocean.printOcean();
               // ocean.printOcean(); 
            //Console.WriteLine("Computer board:");
            /*while (true){#1#
                Console.WriteLine("Score: " + player.Points); 
                ocean.printOcean();
                /*player.placeShoot(ocean);#1#
                Console.WriteLine("Score enemy: " + enemy.Points); 
                /*oceanEnemy.printOcean();#1#
                /*enemy.placeRandomShoot(oceanEnemy);
                if (player.score >= maxPoints ) {
                    System.out.println("You won!!!");
                    restartGame();
                
                }
                if (enemy.score >= maxPoints) {
                    System.out.println("Computer won!!!");
                    restartGame();
                }#1#
            }
        }*/
        }
    }
}