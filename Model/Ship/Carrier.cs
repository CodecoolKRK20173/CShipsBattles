namespace CShipsBattles.Model
{
    public class Carrier : Ship
    {
        public override int ShipSize => 5;
        public override string Look => Helpers.Cell.ship;
    }
}