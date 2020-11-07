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

        public void PlaceShip(/*Coordinates coordinates, */Ship ship, Ocean ocean)
        {
            bool[] _is_place_available = new bool[ship.Size];
            int x = random.Next(0,15);
            int y = random.Next(0,15);
            Console.WriteLine(x + "  y: " + y);
            try
            {
                for (int j = 0; j < _is_place_available.Length; j++)
                {
                    if (ocean.OceanField[x + j, y].Look.Equals(Helpers.Cell.wave))
                    {
                        _is_place_available[j] = true;
                    }
                    else
                    {
                        _is_place_available[j] = false;
                    }
                }

                if (isAllTrue(_is_place_available))
                {
                    for (int i = 0; i < ship.Size; i++)
                    {
                        ocean.OceanField[x + i, y].Look = Helpers.Cell.ship;
                    }
                }
                else
                {
                    PlaceShip(ship, ocean);
                }
            }
            catch (IndexOutOfRangeException)
            {
                PlaceShip(ship, ocean);
            }


        }

        public bool _shoot(Ocean ocean)
        {
            return false;
        }
        
        private bool isAllTrue(bool[] arr) {
            foreach (bool b in arr)
                if (!b)
                    return false;
            return true;
        }
    }
}