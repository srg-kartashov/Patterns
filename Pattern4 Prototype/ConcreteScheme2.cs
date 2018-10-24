namespace Pattern4_Prototype
{
    class ConcreteScheme2 : Scheme
    {
        //public List<Body> _bdy = new List<Body>();

        public override Scheme Clone()
        {
            ConcreteScheme2 concreteScheme2 = new ConcreteScheme2();
            for (int i = 0; i < Bdy.Count; i++)
            {
                concreteScheme2.Bdy.Add(new Body(Bdy[i].Length, Bdy[i].Name));
            }
            return concreteScheme2;
        }
    }
}
