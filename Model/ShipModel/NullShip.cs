namespace CShipsBattles.Model.ShipModel
{
    public class NullShip : Ship
    {
        public override int Size => 0;
        public override string Look => Helpers.Cell.ship;
    }
}