using System;
using System.Collections.Generic;
using CShipsBattles.Model;

namespace CShipsBattles.Helpers
{
    public class CoordinatesGenerated
    {
        
        public static List<Coordinates> _coordinates = new List<Coordinates>();

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