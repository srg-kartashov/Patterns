namespace Pattern2_Builder
{
    class Golf2Builder:CarBuilder
    {
        Car car = new Car();
        public override void BuildWheel()
        {
            car.Wheel = Wheel.Summer;
        }

        public override void BuildCarCase()
        {
            car.Carcase = Carcase.Hatchback;
        }

        public override void BuildColor()
        {
            car.Color = Color.Black;
        }

        public override void BuildCabin()
        {
            car.Cabin = Cabin.Leather;
        }
        public override Car GetNewCar()
        {

            return car;
        }
    }
}
