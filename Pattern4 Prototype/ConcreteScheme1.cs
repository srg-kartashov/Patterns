namespace Pattern4_Prototype
{
    class ConcreteScheme1 : Scheme
    {
        //public List<Body> _bdy = new List<Body>();
        

        public override Scheme Clone()
        {
            return (ConcreteScheme1)MemberwiseClone();
        }
    }
}
