namespace CShipsBattles.Model
{
    public abstract class Ship
    {
        protected Ship() {}

        /*public int Size
        {
            get => size;
            set => size = value;
        }*/

        public abstract string Look {get;}
        
        public abstract int ShipSize {get;} 
    }
}