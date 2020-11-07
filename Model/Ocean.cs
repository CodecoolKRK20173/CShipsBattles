using System;

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
    }
}