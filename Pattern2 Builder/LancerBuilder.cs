namespace Pattern2_Builder
{
    class LancerBuilder : CarBuilder
    {
        Car car = new Car();
        public override void BuildWheel()
        {
            car.Wheel = Wheel.Winter;
        }

        public override void BuildCarCase()
        {
            car.Carcase = Carcase.Sedan;
        }

        public override void BuildColor()
        {
            car.Color = Color.Red;
        }

        public override void BuildCabin()
        {
            car.Cabin = Cabin.Suede;
        }
        public override Car GetNewCar()
        {

            return car;
        }
    }
}
