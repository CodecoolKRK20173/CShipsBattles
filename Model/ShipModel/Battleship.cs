namespace CShipsBattles.Model.ShipModel
{
    public class Battleship : Ship
    {
        public override int ShipSize => 4;
        public override string Look => Helpers.Cell.ship;
    }
}