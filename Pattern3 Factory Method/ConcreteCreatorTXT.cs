namespace Pattern3_Factory_Method
{
    class ConcreteCreatorTXT:Creator
    {
        public override TextFile FactoryMethod(string fileName, string text)
        {
            return new ConcreteTextFileTXT(fileName,text);
        }
    }
}
