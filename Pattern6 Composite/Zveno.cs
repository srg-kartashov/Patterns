using System.Collections.Generic;
using System.Windows.Forms;

namespace Pattern6_Composite
{
    class Zveno : Component
    {
        private List<Component> components = new List<Component>();

        public Zveno(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Draw(ListBox l)
        {
            l.Items.Add("Звено: " + Name);

            l.Items.Add("Подузлы: ");
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Draw(l);
            }
        }
    }
}
