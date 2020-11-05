using System;
using System.Runtime.CompilerServices;
using CShipsBattles.Controller.Game;
using CShipsBattles.Controller.Game.Service;

namespace CShipsBattles
{
    class Program
    {
        static void Main(string[] args)
        {
            ShipFactory s = new ShipFactory();
            s._ship();
        }
    }
}
