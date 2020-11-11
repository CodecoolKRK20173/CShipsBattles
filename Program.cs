using System;
using CShipsBattles.Controller.Game;
using CShipsBattles.Helpers;
using CShipsBattles.Model;
using CSE = CShipsBattles.Enums;

namespace CShipsBattles
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var oc = new Ocean(15,15);
            var en = new Ocean(15,15);
            var pl = new Player("Marta", 10, 100);
            Player enem;
            enem = new Player("Enemy", 10, 100);
            //CoordinatesGenerated.coordGenerate();
            var sp = new SinglePlayer();
            sp.Game(ocean: oc, oceanEnemy: en, player: pl, enemy: enem);
        }
    }
}
