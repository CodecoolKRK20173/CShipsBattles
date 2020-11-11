using System;
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

        public void PlaceShipVertically(Coordinates coordinates, Ship ship, Ocean ocean)
        {
            for (var j = 0; j < ship.Size; j++)
            {
                ocean.OceanField[coordinates.X + j, coordinates.Y].Look = Helpers.Cell.ship;
            }
        }

        public static bool is_place_available(Coordinates coordinates, Ship ship, Ocean ocean)
        {
            var i = 0;
            try
            {
                for (var j = 0; j < ship.Size; j++)
                {
                    if (ocean.OceanField[coordinates.X + j, coordinates.Y].Look.Equals(Helpers.Cell.wave))
                    {
                        i += 1;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }

            return i == ship.Size;
        }
        
        public static bool is_place_in_range(Coordinates coordinates, Ship ship, Ocean ocean)
        {
            return ocean.X - coordinates.X - ship.Size >= 0;
        }
        
        public void PlaceShipHorizontally(Coordinates coordinates, Ship ship, Ocean ocean)
        {
            for (var j = 0; j < ship.Size; j++)
            {
                ocean.OceanField[coordinates.X, coordinates.Y+j].Look = Helpers.Cell.ship;
            }
        }

        public bool _shoot(Ocean ocean)
        {
            return false;
        }
        
        public static bool is_place_availableHor(Coordinates coordinates, Ship ship, Ocean ocean)
        {
            var i = 0;
            try
            {
                for (var j = 0; j < ship.Size; j++)
                {
                    if (ocean.OceanField[coordinates.X, coordinates.Y+j].Look.Equals(Helpers.Cell.wave))
                    {
                        i += 1;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }

            return i == ship.Size;
        }
        
        public static bool is_place_in_rangeHor(Coordinates coordinates, Ship ship, Ocean ocean)
        {
            return ocean.Y - coordinates.Y - ship.Size >= 0;
        }
    }
}