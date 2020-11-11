using CShipsBattles.Model.ShipModel;
using CSE = CShipsBattles.Enums;

namespace CShipsBattles.Controller
{
    public struct ShipFactory
    {
        public static Ship ship(CSE.ShipNames ship)
        {
            return ship switch
            {
                CSE.ShipNames.Battleship => new Battleship(),
                CSE.ShipNames.Destroyer => new Destroyer(),
                CSE.ShipNames.Cruiser => new Cruiser(),
                CSE.ShipNames.Submarine => new Submarine(),
                CSE.ShipNames.Carrier => new Carrier(),
                _ => new NullShip()
            };
        }
    }
}