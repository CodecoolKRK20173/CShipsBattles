using System;

namespace CShipsBattles.Controller
{
    public struct Input
    {
        public string getStringInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public int getintInput(string message)
        {
            Console.WriteLine(message);
            return Int32.Parse(Console.ReadLine());
        }
    }
}