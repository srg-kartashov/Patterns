using System;
using System.Windows.Forms;

namespace Pattern8_ChainOfResponsibility
{
    public partial class Form1 : Form
    {
        private ConcreteMechBody concreteMechBody;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int count = (int)numericUpDown1.Value;
            concreteMechBody = new ConcreteMechBody(0, 0);
            concreteMechBody.Display(listBox2);
            ConcreteMechBody cmb1 = concreteMechBody;
            ConcreteMechBody cmb2;

            for(int i = 1;i<count;i++)
            { 
                cmb2 = new ConcreteMechBody(10 * i, 100 * i);
                cmb1.Successor = cmb2;
                cmb1.Successor.Display(listBox2);
                cmb1 = cmb2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mass = (int)numericUpDown2.Value;
            concreteMechBody.MassRequest(mass, listBox1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDown3.Value;
            concreteMechBody.SizeRequest(size, listBox1);
        }
    }
}
