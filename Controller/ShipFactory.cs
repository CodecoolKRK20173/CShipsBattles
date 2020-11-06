using CShipsBattles.Model.ShipModel;
using CSE = CShipsBattles.Enums;

namespace CShipsBattles.Controller
{
    public class ShipFactory
    {
        public Ship ship(CSE.ShipNames ship)
        {
            // foreach (string s in CSE.ShipNames.GetNames(typeof(CSE.ShipNames)))
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