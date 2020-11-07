namespace CShipsBattles.Model.ShipModel
{
    public class Carrier : Ship
    {
        public override int Size => 5;
        public override string Look => Helpers.Cell.ship;
    }
}