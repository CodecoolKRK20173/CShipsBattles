namespace CShipsBattles.Model.ShipModel
{
    public class Battleship : Ship
    {
        public override int Size => 4;
        public override string Look => Helpers.Cell.ship;
    }
}