using System;


namespace CShipsBattles.Model
{
    public class Player
    {
        private string name;
        private byte points;
        private sbyte lives;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public byte Points
        {
            get => points;
            set => points = value;
        }

        public sbyte Lives
        {
            get => lives;
            set => lives = value;
        }
        
        public Player(string name, byte points, sbyte lives)
        {
            this.name = name;
            this.points = points;
            this.lives = lives;
        }
        
        public void PlaceShip(ref Coordinates coordinates, ref Ship ship, ref Ocean ocean)
        {
            bool[] _is_place_available = new bool[ship.Size];
            try
            {
                for (int j = 0; j < _is_place_available.Length; j++)
                {
                    if (ocean.OceanField[coordinates.X + j, coordinates.Y].Look.Equals(Helpers.Cell.wave))
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
                        ocean.OceanField[coordinates.X + i, coordinates.Y].Look = Helpers.Cell.ship;
                    }
                }
                else
                {
                    PlaceShip(ref coordinates, ref ship, ref ocean);
                }
            }
            catch (IndexOutOfRangeException)
            {
                PlaceShip(ref coordinates, ref ship, ref ocean);
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