namespace Pattern1_AbstractFactory
{
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA(string name, float mass, float velocity, float acceleration)
        {

            return new ProductA2(name, mass, velocity, acceleration);

        }
        public override AbstractProductB CreateProductB(string name, float mass, float aVelocity, float aAcceleration)
        {

            return new ProductB2(name, mass, aVelocity, aAcceleration);
        }
    }
}
