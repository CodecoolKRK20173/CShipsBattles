using System;
using static System.Console;
using CShipsBattles.Model;

namespace CShipsBattles.Controller
{
    public class Input
    {
        public static string GetStringInput(string message)
        {
            WriteLine(message);
            return ReadLine();
        }
        
        public static string GetDirection(string message)
        {
            var dir = "";
            while (!dir.Equals("h") && !dir.Equals("v"))
            {
                WriteLine(message);
                dir = ReadLine();
            }
            return dir;
        }

        private static int GetIntInput(string message)
        {
            WriteLine(message);
            return Int32.Parse(ReadLine());
        }

        public static Coordinates GetCoordinates(string message)
        {
            WriteLine(message);
            var x = GetIntInput("Give me direction for x");
            var y = GetIntInput("Give me direction for y");
            return new Coordinates(x, y);
        }

        public static Coordinates GetShootPosition(string message)
        {
            WriteLine(message);
            var x = GetIntInput("Give me number for x");
            var y = GetIntInput("Give me number for y");
            return new Coordinates(x, y);
        }
    }
}