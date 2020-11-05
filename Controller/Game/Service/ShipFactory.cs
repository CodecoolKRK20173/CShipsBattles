using System;
using CShipsBattles.Model;
using CSE = CShipsBattles.Enums;

namespace CShipsBattles.Controller.Game.Service
{
    public struct ShipFactory
    {
        public void ShipCreation()
        {
            int shipLength = 0;
            foreach(byte i in Enum.GetValues(typeof(CSE.Ship)))
            {
                shipLength += i;
            }
        }
    }
}
