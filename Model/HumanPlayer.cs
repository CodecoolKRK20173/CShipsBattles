using System;

namespace CShipsBattles.Model
{
    public class HumanPlayer : Player, Controller.PlayerController.IPlayerController
    {
        public HumanPlayer(string name, byte points, sbyte lives) : base(name, points, lives)
        {
        }

        public void PlaceShip(/*Coordinates coordinates, */Ship ship, Ocean ocan)
        {
            Console.WriteLine();
        }

        public bool _shoot(Ocean ocean)
        {
            return false;
        }
    }
}