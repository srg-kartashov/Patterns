namespace Pattern1_AbstractFactory
{
    abstract class AbstractProductA
    {
        public string Name;
        public float Mass;
        public float Velocity;
        public float Acceleration;
        public abstract void Move();

        protected AbstractProductA(string name, float mass, float velocity, float acceleration)
        {
            Name = name;
            Mass = mass;
            Velocity = velocity;
            Acceleration = acceleration;
        }
    }
}
