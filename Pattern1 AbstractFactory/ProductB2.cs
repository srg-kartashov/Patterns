namespace Pattern1_AbstractFactory
{
    class ProductB2 : AbstractProductB
    {
        public ProductB2(string name, float mass, float velocity, float acceleration) : base(name, mass, velocity, acceleration)
        {
        }

        public override void Move()
        {

        }
    }
}
