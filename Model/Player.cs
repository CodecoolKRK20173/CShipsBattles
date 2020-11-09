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

        public void PlaceShip(Coordinates coordinates, Ship ship, Ocean ocean)
        {
            /*while (true)
            {
                if (is_place_in_range(coordinates, ship, ocean) && is_place_available(coordinates, ship, ocean))
                {*/
                    for (var j = 0; j < ship.Size; j++)
                    {
                        ocean.OceanField[coordinates.X + j, coordinates.Y].Look = Helpers.Cell.ship;
                    }
                /*}
                else
                {
                    CoordinatesGenerated.coordGenerate();
                }
                break;
            }*/
        }

        public bool _shoot(Ocean ocean)
        {
            return false;
        }
        
        public static bool is_place_available(Coordinates coordinates, Ship ship, Ocean ocean)
        {
            for (var j = 0; j < ship.Size; j++)
            {
                if (ocean.OceanField[coordinates.X + j, coordinates.Y].Look.Equals(Helpers.Cell.wave))
                    return true;
            }
            return false;
        }
        
        public static bool is_place_in_range(Coordinates coordinates, Ship ship, Ocean ocean)
        {
            if (ocean.X - coordinates.X - ship.Size <= 0 && coordinates.Y < ocean.Y)
                return true;
            return false;
        }
    }
}