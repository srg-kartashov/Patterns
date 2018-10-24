using System.Windows.Forms;

namespace Pattern6_Composite
{
    abstract class Component
    {
        protected string Name;

        public Component(string name)
        {
            Name = name;
        }

        public virtual void Draw(ListBox l)
        {
            l.Items.Add(Name);
        }

        public virtual void Add(Component c) { }
        public virtual void Remove(Component c) { }
    }
}
