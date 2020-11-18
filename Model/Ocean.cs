using System;
using System.Collections.Generic;

namespace CShipsBattles.Model
{
    public class Ocean
    {
        private Cell[,] ocean;
        //private byte x;//width
        //private byte y;//height
        public byte X
        {
            get;
        }
        public byte Y
        {
            get;
        }
        public Ocean(byte x, byte y)
        {
            this.X = x;
            this.Y = y;
            ocean = new Cell[x,y];
            for (byte i = 0; i < X; i++)
            {
                for (byte j = 0; j < Y; j++)
                {
                    ocean[i, j] = new Cell(Helpers.Cell.wave);
                }
            }
        }

        public Cell[,] OceanField
        {
            get=>ocean;}

        
        //to string stringbuilder
        public void printOcean()
        {
            string printedLine = "";
            for (byte i = 0; i < X; i++) {
                for (byte j = 0; j <Y; j++)
                {
                    printedLine += ocean[i,j].Look + "  ";
                }
                Console.WriteLine(printedLine);
                printedLine = "";
            }
        }

        public void PlaceShoot(Player player, Coordinates coordinates, List<Coordinates> shipCoordList)
        //TODO change for checking in list ships coordinates!!!
        {
            foreach (var coord in shipCoordList)
            {
                if (coord.Equals(coordinates))
                {
                    OceanField[coordinates.X, coordinates.Y].Look = Helpers.Cell.hit;
                    player.Points += 1;
                }
                //TODO ask why those coordinates, WTF with this boxing allocation
                else if (!coord.Equals(coordinates) && 
                         OceanField[coordinates.X, coordinates.Y].Look.Equals(Helpers.Cell.wave))
                {
                    OceanField[coordinates.X, coordinates.Y].Look = Helpers.Cell.loose;
                    player.Lives -= 1;
                    printOcean();
                }
            }
        }
    }
}