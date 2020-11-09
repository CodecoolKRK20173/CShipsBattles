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
                    Coordinates coordinates = new Coordinates(x, y);
                    var sh = ShipFactory.ship(name);
                    /*try
                    {
                       // Console.WriteLine("x: "*//* +x+ ", y: " + y);*/
                    player.PlaceShip(coordinates, sh, ocean);
                    /*}catch (IndexOutOfRangeException)
                    {
                     //   Console.WriteLine("blabla");
                     //   CoordinatesGenerated.coordGenerate();
                       // Coordinates coordinates2 = new Coordinates(x, y);
                       // Console.WriteLine("x: " +x+ ", y: " + y);
                       player.PlaceShip(coordinates, sh, ocean);
                    }*/
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