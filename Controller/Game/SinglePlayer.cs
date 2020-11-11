using CSE = CShipsBattles.Enums;
using System;
using System.Data;
using CShipsBattles.Helpers;
using CShipsBattles.Model;

namespace CShipsBattles.Controller.Game
{
    public class SinglePlayer /*\\: IGame*/
    {
        Random random = new Random();

        public void Game(Ocean ocean, Ocean oceanEnemy,
            Player player, Player enemy)
        {

            // oceanEnemy.printOcean();
            /*CoordinatesGenerated.coordGenerate();
           
            foreach (int i in Enum.GetValues(typeof(CSE.ShipNames)))
            {
                CSE.ShipNames name = (CSE.ShipNames) i;
                var sh = ShipFactory.ship(name);
                var coordinates = CoordinatesGenerated._coordinates[i];
                var dir = random.Next(0, 2);
                switch (dir)
                {
                    case 0:
                        while (!Player.is_place_available(coordinates, sh, ocean) ||
                               !Player.is_place_in_range(coordinates, sh, ocean))
                        {
                            CoordinatesGenerated._coordinates.Clear();
                            CoordinatesGenerated.coordGenerate();
                            coordinates = CoordinatesGenerated._coordinates[i];
                        }
                        player.PlaceShipVertically(coordinates, sh, ocean);
                        break;
                    case 1:
                        while (!Player.is_place_availableHor(coordinates, sh, ocean) ||
                               !Player.is_place_in_rangeHor(coordinates, sh, ocean))
                        {
                            CoordinatesGenerated._coordinates.Clear();
                            CoordinatesGenerated.coordGenerate();
                            coordinates = CoordinatesGenerated._coordinates[i];
                        }
                        player.PlaceShipHorizontally(coordinates, sh, ocean);
                        break;
                }
            }
            Console.WriteLine("Your board:");
            ocean.printOcean();*/
            foreach (int i in Enum.GetValues(typeof(CSE.ShipNames)))
            {
                CSE.ShipNames name = (CSE.ShipNames) i;
                var sh2 = ShipFactory.ship(name);
                var direction = Input.GetDirection("Give me direction for " + name);
                if (direction.Equals("v"))
                    Console.WriteLine("hor");
                if(direction.Equals("h"))
                    Console.WriteLine("ver");
            }
            }

        
        



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