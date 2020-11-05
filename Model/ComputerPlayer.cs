using System;

namespace CShipsBattles.Model
{
    public class ComputerPlayer : Player, Controller.PlayerController.IPlayerController
    {
        Random random = new Random();
        public ComputerPlayer(string name, byte points, sbyte lives) : base(name, points, lives)
        {
            this.Name = "Computer";
        }

        public void PlaceShip(Coordinates coordinates, Ship ship, Ocean ocean)
        {
            /*bool[] truthy = new bool[ship.Size];
            int x = random.Next(1,16);
            int y = random.Next(1,16);
            for (int j = 0; j < truthy.Length; j++) {
                if (ocean[1,2]) {
                    truthy[j] = true;
                } else {
                    truthy[j] = false;
                }
            }
            if (isAllTrue(truthy)) {
                for (int i = 0; i < ship.getSize(); i++) {
                    ocean.ocean[x + i][y] = ship.shipSquares[i];
                    ocean.ocean[x + i][y] = ship.shipSquares[i];
                    Coordinates c = new Coordinates(x, y);
                    shiPos.add(c);
                }
            }
            else {
                System.out.println("This place is already taken, choose other");
                placeShip(ship, ocean);
            }*/
        }

        public bool _shoot(Ocean ocean)
        {
            return false;
        }
    }
}