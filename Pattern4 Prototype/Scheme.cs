using System.Collections.Generic;

namespace Pattern4_Prototype
{
    public abstract class Scheme
    {
        public List<Body> Bdy = new List<Body>();
        public abstract Scheme Clone();
    }
}
