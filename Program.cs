using System;
using CShipsBattles.Controller.Game;

namespace CShipsBattles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IGame game = new FriendBattle();
            
        }
    }
}
