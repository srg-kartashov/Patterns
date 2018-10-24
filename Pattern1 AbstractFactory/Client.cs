namespace Pattern1_AbstractFactory
{
    class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;


        // Constructor
        public Client(AbstractFactory factory, string name, float mass, float velocity, float acceleration, string aName, float aMass, float aVelocity, float aAcceleration)
        {
            abstractProductA = factory.CreateProductA(name, mass, velocity, acceleration);
            abstractProductB = factory.CreateProductB(aName, aMass, aVelocity, aAcceleration);


        }
        public string Info()
        {
            string s = "Prodact1" +abstractProductA.Name+" " +abstractProductA.Mass+" "+ abstractProductA.Velocity+ " " + abstractProductA.Acceleration;
            s += "Prodact2" + abstractProductB.Name + " " + abstractProductB.Mass + " " + abstractProductB.Velocity + " " + abstractProductB.Acceleration;
            return s;
        }
        public void MoveProducts()
        {
            abstractProductA.Move();
            abstractProductB.Move();
        }
    }
}
