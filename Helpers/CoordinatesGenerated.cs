using System;
using System.Collections.Generic;
using CShipsBattles.Model;

namespace CShipsBattles.Helpers
{
    public struct CoordinatesGenerated
    {
        
        public static readonly List<Coordinates> _coordinates = new List<Coordinates>();

        public static void coordGenerate()
        {
            var random = new Random();
            for (var i =0; i<5; i++)
            {
                var x = random.Next(0,15);
                var y = random.Next(0,15);
                var coordinates = new Coordinates(x,y);
                _coordinates.Add(coordinates);
            }   
        }
    }
}