namespace CShipsBattles.Model
{
    public class Battleship : Ship
    {
        public override int ShipSize => 4;
        public override string Look => Helpers.Cell.ship;
    }
}