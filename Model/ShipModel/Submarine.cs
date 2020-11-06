namespace CShipsBattles.Model.ShipModel
{
    public class Submarine : Ship
    {
        public override int ShipSize => 3;
        public override string Look => Helpers.Cell.ship;
    }
}