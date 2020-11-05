using System;
using CShipsBattles.Model;

namespace CShipsBattles
{
    class Program
    {
        static void Main(string[] args)
        {
            Ocean ocean = new Ocean(15,15);
            ocean.printOcean();
        }
    }
}
