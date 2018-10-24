using System.Windows.Forms;

namespace Pattern6_Composite
{
    public partial class Form1 : Form
    {
        Component mech = new Zveno("Механизм");
        Component weel1 = new Zveno("Колесо1");
        Component weel2 = new Zveno("Колесо2");
        Component weel3 = new Zveno("Колесо3");
        Component kreew = new Zveno("Кривошип");
        Component zakrep = new Creplenie("Закрепление");
        Component podsh1 = new Creplenie("Подшипник1");
        Component podsh2 = new Creplenie("Подшипник2");
        Component podsh3 = new Creplenie("Подшипник3");


        public Form1()
        {
            InitializeComponent();
            mech.Add(weel1);
            mech.Add(weel2);
            mech.Add(weel3);
            mech.Add(kreew);
            weel1.Add(zakrep);
            weel1.Add(podsh1);
            weel2.Add(podsh2);
            weel3.Add(podsh3);
            kreew.Add(podsh1);
            kreew.Add(podsh2);
            kreew.Add(podsh3);
            mech.Draw(listBox1);
        }
    }
}
