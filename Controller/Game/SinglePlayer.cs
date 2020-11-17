using CSE = CShipsBattles.Enums;
using System;
using CShipsBattles.Helpers;
using CShipsBattles.Model;

namespace CShipsBattles.Controller.Game
{
    public class SinglePlayer /*\\: IGame*/
    {
        Random random = new Random();

        public void Game()
        {
            var ocean = new Ocean(15, 15);
            var oceanEnemy = new Ocean(15, 15);
            var enemy = new Player("Marta", 0, 7);
            var player = new Player("Computer", 0, 7);
            CoordinatesGenerated.coordGenerate();
            PlaceAllShips(ocean, oceanEnemy, player, enemy);
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
            while (ShouldGameLast(player, enemy))
            {
                Console.WriteLine("Shoot " + enemy.Name);
                Console.WriteLine("Your score is: " + enemy.Points);
                Console.WriteLine("You have " + enemy.Lives + " lives left.");
                //ocean.printOcean();
                var shootCoordinates = Input.GetShootPosition("Where to place shoot?");
                ocean.PlaceShoot(enemy, shootCoordinates, ShipsCoordinates.Coordinates1);
            }
        }

        private void PlaceAllShips(Ocean ocean, Ocean oceanEnemy,
            Player player, Player enemy)
        {
            foreach (int i in Enum.GetValues(typeof(CSE.ShipNames)))
            {
                var name = (CSE.ShipNames) i;
                var sh = ShipFactory.ship(name);
                var coordinates = CoordinatesGenerated._coordinates[i];
                var dir = random.Next(0, 2);
                switch (dir)
                {
                    case 0:
                        while (!Player.is_place_available(coordinates, sh, ocean))
                        {
                            CoordinatesGenerated._coordinates.Clear();
                            CoordinatesGenerated.coordGenerate();
                            coordinates = CoordinatesGenerated._coordinates[i];
                        }
                        ShipsCoordinates.Coordinates1.Add(coordinates);
                        //player.PlaceShipVertically(coordinates, sh, ocean);
                        break;
                    case 1:
                        while (!Player.is_place_availableHor(coordinates, sh, ocean))
                        {
                            CoordinatesGenerated._coordinates.Clear();
                            CoordinatesGenerated.coordGenerate();
                            coordinates = CoordinatesGenerated._coordinates[i];
                        }
                        ShipsCoordinates.Coordinates1.Add(coordinates);
                        //player.PlaceShipHorizontally(coordinates, sh, ocean);
                        break;
                }
            }

            Console.WriteLine("Your board:");
            ocean.printOcean();
            foreach (int i in Enum.GetValues(typeof(CSE.ShipNames)))
            {
                var name = (CSE.ShipNames) i;
                var sh2 = ShipFactory.ship(name);
                var direction = Input.GetDirection("Give me direction for " + name);
                var coo = new Coordinates(100, 100);
                switch (direction)
                {
                    case "v":
                        while (!Player.is_place_available(coo, sh2, oceanEnemy))
                        {
                            coo = Input.GetCoordinates("Give me coordinates for " + name);
                        }
                        ShipsCoordinates.Coordinates2.Add(coo);
                        //enemy.PlaceShipVertically(coo, sh2, oceanEnemy);
                        oceanEnemy.printOcean();
                        break;
                    case "h":
                        while (!Player.is_place_availableHor(coo, sh2, oceanEnemy))
                        {
                            coo = Input.GetCoordinates("Give me coordinates for " + name);
                        }
                        ShipsCoordinates.Coordinates2.Add(coo);
                        //enemy.PlaceShipHorizontally(coo, sh2, oceanEnemy);
                        oceanEnemy.printOcean();
                        break;
                }
            }
        }

        private bool ShouldGameLast(Player player, Player enemy)
        {
            if (player.Lives <= 0 || enemy.Lives <= 0 || player.Points == 17 || enemy.Points == 17)
                return false;
            return true;
        }
    }
}