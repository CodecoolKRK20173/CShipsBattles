namespace CShipsBattles.Model.ShipModel
{
    public class Cruiser : Ship
    {
        public override int Size => 3;
        public override string Look => Helpers.Cell.ship;
    }
}