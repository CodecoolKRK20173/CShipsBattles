using System;

namespace CShipsBattles.Controller
{
    public struct Input
    {
        public static string GetStringInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        
        public static string GetDirection(string message)
        {
            string dir = "";
            while (!dir.Equals("h") && !dir.Equals("v"))
            {
                Console.WriteLine(message);
                dir = Console.ReadLine();
            }
            return dir;
        }

        public static int GetIntInput(string message)
        {
            Console.WriteLine(message);
            return Int32.Parse(Console.ReadLine());
        }
    }
}