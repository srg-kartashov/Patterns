namespace Pattern1_AbstractFactory
{
    class ConcreteFactory1 : AbstractFactory
    {

        public override AbstractProductA CreateProductA(string name, float mass, float velocity, float acceleration)
        { 
           
            return new ProductA1(name,mass,velocity,acceleration); 
           
        }
        public override AbstractProductB CreateProductB(string name, float mass, float aVelocity, float aAcceleration)
        {
            
            return new ProductB1(name,mass,aVelocity,aAcceleration); 
        }
    }
}
