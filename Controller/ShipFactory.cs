using CShipsBattles.Model.ShipModel;
using CShipsBattles.Enums;

namespace CShipsBattles.Controller
{
    public struct ShipFactory
    {
        public static Ship ship(ShipNames ship)
        {
            return ship switch
            {
                ShipNames.Battleship => new Battleship(),
                ShipNames.Destroyer => new Destroyer(),
                ShipNames.Cruiser => new Cruiser(),
                ShipNames.Submarine => new Submarine(),
                ShipNames.Carrier => new Carrier(),
                _ => new NullShip()
            };
        }
    }
}