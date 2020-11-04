using System;

namespace CShipsBattles.Model
{
    public struct Ocean
    {
        private Cell[,] ocean;
        private int x;
        private int y;
        public int X
        {
            get => x;
        }
        public int Y
        {
            get => y;
        }
        public Ocean(int x, int y)
        {
            this.x = x;
            this.y = y;
            ocean = new Cell[x,y];
        }

        public Cell[,] OceanField
        {
            get
            {
                for (int i = 0; i < X; i++)
                {
                    for (int j = 0; j < Y; j++)
                    {
                        ocean[i, j] = new Cell(Helpers.Cell.wave);
                    }
                }
                return ocean;
            }
        }

        public void printOcean()
        {
            string printedLine = "";
            for (int i = 0; i < X; i++) {
                for (int j = 0; j <Y; j++)
                {
                    printedLine += ocean[i,j].Look + "  ";
                }
                Console.WriteLine(printedLine);
                printedLine = "";
            }
        }
    }
}