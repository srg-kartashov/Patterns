namespace Pattern2_Builder
{
    abstract class CarBuilder
    {
        public abstract Car GetNewCar();
        public abstract void BuildWheel();
        public abstract void BuildCarCase();
        public abstract void BuildColor();
        public abstract void BuildCabin();

    }
}
