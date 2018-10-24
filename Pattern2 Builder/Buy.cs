namespace Pattern2_Builder
{
    class Buy
    {
        public void ConstructCar(CarBuilder carBuilder)
        {

            carBuilder.BuildCabin();
            carBuilder.BuildCarCase();
            carBuilder.BuildColor();
            carBuilder.BuildWheel();
        }
    }
}
