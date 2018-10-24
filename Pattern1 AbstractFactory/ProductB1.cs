namespace Pattern1_AbstractFactory
{
    class ProductB1 : AbstractProductB
    {

        public ProductB1(string name, float mass, float velocity, float acceleration) : base(name, mass, velocity, acceleration)
        {
        }

        public override void Move()
        {

        }
    }
}
