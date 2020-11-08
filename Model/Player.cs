using System;
using System.Linq;
using CShipsBattles.Helpers;
using CShipsBattles.Model.ShipModel;

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

        public void PlaceShip(Coordinates coordinates, Ship ship, Ocean ocean)
        {
            bool[] _is_place_available = new bool[ship.Size];
            try
            {
                for (int j = 0; j < _is_place_available.Length; j++)
                {
                    if (ocean.OceanField[coordinates.X + j, coordinates.Y].Look.Equals(Helpers.Cell.wave))
                    {
                        _is_place_available[j] = true;
                        for (int i = 0; i < ship.Size; i++)
                        {
                            ocean.OceanField[coordinates.X + i, coordinates.Y].Look = Helpers.Cell.ship;
                        }
                    }
                    else
                    {
                        _is_place_available[j] = false;
                        CoordinatesGenerated.coordGenerate();
                    }
                }

                /*if (isAllTrue(_is_place_available))
                {
                    for (int i = 0; i < ship.Size; i++)
                    {
                        ocean.OceanField[coordinates.X + i, coordinates.Y].Look = Helpers.Cell.ship;
                    }
                }*/
                /*else
                {
                    CoordinatesGenerated.coordGenerate();*/
                    //PlaceShip(new Coordinates(), ship, ocean);
                //}
            }
            catch (IndexOutOfRangeException)
            {
                CoordinatesGenerated.coordGenerate();
                //PlaceShip(coordinates, ship, ocean);

            }
        }

        public bool _shoot(Ocean ocean)
        {
            return false;
        }
        
        private bool isAllTrue(bool[] arr)
        {
            return arr.All(b => b);
        }
    }
}