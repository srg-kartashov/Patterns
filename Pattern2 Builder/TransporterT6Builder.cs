namespace Pattern2_Builder
{
    class TransporterT6Builder:CarBuilder
    {
        Car car = new Car();
        public override void BuildWheel()
        {
            car.Wheel = Wheel.Universal;
        }

        public override void BuildCarCase()
        {
            car.Carcase = Carcase.Wagon;
        }

        public override void BuildColor()
        {
            car.Color = Color.Silver;
        }

        public override void BuildCabin()
        {
            car.Cabin = Cabin.Carbon;
        }
        public override Car GetNewCar()
        {

            return car;
        }
    }
}
