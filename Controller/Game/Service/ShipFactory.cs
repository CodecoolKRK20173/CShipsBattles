using System;
using CShipsBattles.Model;
using CSE = CShipsBattles.Enums;

namespace CShipsBattles.Controller.Game.Service
{
    public struct ShipFactory
    {
        public Ship _ship()
        {
            Ship ship = new Ship();
            foreach(int i in Enum.GetValues(typeof(CSE.Ship)))
            {
                ship = new Ship(i, Helpers.Cell.ship);
            }
            return ship;
        }
    }
}
