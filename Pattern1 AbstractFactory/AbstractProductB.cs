namespace Pattern1_AbstractFactory
{
    abstract class AbstractProductB
    {
        public string Name;
        public float Mass;
        public float Velocity;
        public float Acceleration;
        public abstract void Move();

        protected AbstractProductB(string name, float mass, float velocity, float acceleration)
        {
            Name = name;
            Mass = mass;
            Velocity = velocity;
            Acceleration = acceleration;
        }
    }
}
