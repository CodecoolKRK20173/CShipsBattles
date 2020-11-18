using CShipsBattles.Controller.Game;
using CSE = CShipsBattles.Enums;

namespace CShipsBattles
{
    class Program
    {
        static void Main(string[] args)
        {
            var sp = new SinglePlayer();
            sp.Game();
        }
    }
}
