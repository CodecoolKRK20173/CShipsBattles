using CSE = CShipsBattles.Enums;
using System;
using CShipsBattles.Model;

namespace CShipsBattles.Controller.Game
{
    public class SinglePlayer : IGame
    {
        public void Game(ref Ocean ocean, ref Ocean oceanEnemy, 
                         ref Player player, ref Player enemy)
        {
            /*CSE.Ship shi = CSE.Ship.Battleship;
            Ship ship = new Ship(4, "#");
            
            oceanEnemy.printOcean();*/
            /*oceanEnemy.printOcean();*/
            /*foreach (int i in Enum.GetValues(typeof(CSE.Ship))) {
                Console.WriteLine("Give your coordinates for " + (CSE.Ship)i + " :\n");
                /*enemy.placeShip(new Ship(shipsLenghts[i], shipsLooks[i]), oceanEnemy);#1#
            }
            Console.WriteLine("Your board:");
            /*ocean.fillOcean();#1#*/
            Random random = new Random();
            foreach(int i in Enum.GetValues(typeof(CSE.Ship)))
            {
                int x = random.Next(0,15);
                int y = random.Next(0,15);
                Coordinates coordinates = new Coordinates(x, y);
                Ship ship = new Ship(i, Helpers.Cell.ship);
                Console.WriteLine("x: "+x+"y: "+y); 
                Console.WriteLine("size: "+ship.Size);
                player.PlaceShip(ref coordinates, ref ship, ref ocean);
            }
            Console.WriteLine("Computer board:");
            /*while (true){*/
                Console.WriteLine("Score: " + player.Points); 
                ocean.printOcean();
                /*player.placeShoot(ocean);*/
                Console.WriteLine("Score enemy: " + enemy.Points); 
                /*oceanEnemy.printOcean();*/
                /*enemy.placeRandomShoot(oceanEnemy);
                if (player.score >= maxPoints ) {
                    System.out.println("You won!!!");
                    restartGame();
                
                }
                if (enemy.score >= maxPoints) {
                    System.out.println("Computer won!!!");
                    restartGame();
                }*/
            /*} */
        }

        
    }
}