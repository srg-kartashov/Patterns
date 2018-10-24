namespace Pattern3_Factory_Method
{
    abstract class Creator
    {
        public abstract TextFile FactoryMethod(string fileName, string text);
    }
}
