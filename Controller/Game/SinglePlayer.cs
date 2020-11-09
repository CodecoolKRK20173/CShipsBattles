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

            //foreach (int i in Enum.GetValues(typeof(CSE.ShipNames)))
            /*{
                CSE.ShipNames name = (CSE.ShipNames) i;
                Console.WriteLine("Give your coordinates for " + (CSE.ShipNames) i + " :\n");
                Coordinates cor = new Coordinates(1, 1);
                //Ship s = new Battleship();
                enemy.PlaceShip(cor, ShipFactory.ship(name), ocean);
            }*/

            Console.WriteLine("Your board:");
           
                foreach (int i in Enum.GetValues(typeof(CSE.ShipNames)))
                {

                    CSE.ShipNames name = (CSE.ShipNames) i;
                    var x = CoordinatesGenerated._coordinates[i - 1].X;
                    var y = CoordinatesGenerated._coordinates[i - 1].Y;
                    var coordinates = new Coordinates(x, y);
                    var sh = ShipFactory.ship(name);
                    try
                    {
                        if (Player.is_place_available(coordinates, sh, ocean) &&
                            Player.is_place_in_range(coordinates, sh, ocean))
                        {
                            player.PlaceShip(coordinates, sh, ocean);
                        }
                        else
                        {
                            CoordinatesGenerated.coordGenerate();
                            var xx = CoordinatesGenerated._coordinates[i - 1].X;
                            var yy = CoordinatesGenerated._coordinates[i - 1].Y;
                            var coordinates2 = new Coordinates(xx, yy);
                            player.PlaceShip(coordinates2, sh, ocean);
                        }
                    }catch (IndexOutOfRangeException)
                    {
                        CoordinatesGenerated.coordGenerate();
                        var xx = CoordinatesGenerated._coordinates[i - 1].X;
                        var yy = CoordinatesGenerated._coordinates[i - 1].Y;
                        var coordinates3 = new Coordinates(xx, yy);
                        player.PlaceShip(coordinates3, sh, ocean);
                    }
                    /*Console.WriteLine("Ocean after: " + i);
                    ocean.printOcean(); */
              
                }
                ocean.printOcean(); 
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