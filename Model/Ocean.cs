using System;

namespace CShipsBattles.Model
{
    public struct Ocean
    {
        private Cell[,] ocean;
        private byte x;
        private byte y;
        public byte X
        {
            get => x;
        }
        public byte Y
        {
            get => y;
        }
        public Ocean(byte x, byte y)
        {
            this.x = x;
            this.y = y;
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
            get => ocean;
        }

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