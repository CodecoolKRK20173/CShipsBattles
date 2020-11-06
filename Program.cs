using System;
using CShipsBattles.Controller.Game;
using CShipsBattles.Model;

namespace CShipsBattles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ocean oc = new Ocean(15,15);
            Ship ship = new Ship(4, "X"); 
            Player p = new Player("Marta", 10, 100);
            p.PlaceShip(coordinates, ship, oc);
            oc.printOcean();*/
            Ocean oc = new Ocean(15,15);
            Ocean en = new Ocean(15,15);
            Player p = new Player("Marta", 10, 100);
            Player enem = new Player("Enemy", 10, 100);
            SinglePlayer sp = new SinglePlayer();
            sp.Game(ref oc, ref en, ref p, ref enem);
    
        }
    }
}
