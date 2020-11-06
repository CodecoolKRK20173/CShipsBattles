namespace CShipsBattles.Model
{
    public class Cruiser : Ship
    {
        public override int ShipSize => 7;
        public override string Look => Helpers.Cell.ship;
    }
}