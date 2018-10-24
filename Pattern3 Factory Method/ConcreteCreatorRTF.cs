namespace Pattern3_Factory_Method
{
    class ConcreteCreatorRTF : Creator
    {
        public override TextFile FactoryMethod(string fileName, string text )
        {
            return new ConcreteTextFileRTF(fileName, text);
        }
    }
}
