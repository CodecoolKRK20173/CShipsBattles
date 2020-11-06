namespace CShipsBattles.Model.ShipModel
{
    public class NullShip : Ship
    {
        public override int ShipSize => 0;
        public override string Look => Helpers.Cell.ship;
    }
}