using CShipsBattles.Model;

namespace CShipsBattles.Controller.PlayerController
{
    public interface IPlayerController
    {
        void PlaceShip(/*Coordinates coordinates, */Ship ship, Ocean ocean);
        bool _shoot(Ocean ocean);
    }
}