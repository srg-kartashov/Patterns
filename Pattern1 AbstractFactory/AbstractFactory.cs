namespace Pattern1_AbstractFactory
{
    abstract class AbstractFactory
    {
       
        public abstract AbstractProductA CreateProductA(string name, float mass, float velocity, float acceleration);
        public abstract AbstractProductB CreateProductB(string name, float mass, float aVelocity, float aAcceleration); 
    }
}
