using System;

namespace CShipsBattles.View
{
    public struct Menu
    {
        private void printGameOptions() {
            Console.WriteLine("To play Singleplayer, choose => 1\n");
            Console.WriteLine("To see computer-computer battle, choose => 2\n");
            Console.WriteLine("To play battle with Your friend, choose => 3\n");
        }
    }
}