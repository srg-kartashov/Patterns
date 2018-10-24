namespace Pattern1_AbstractFactory
{
    class ProductA1 : AbstractProductA
    {

       

        public ProductA1(string name, float mass, float velocity, float acceleration):base(name,mass,velocity,acceleration)
        {
        }

        public override void Move()
        {
        }
    }
}
