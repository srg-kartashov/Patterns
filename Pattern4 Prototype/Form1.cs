using System;
using System.Windows.Forms;

namespace Pattern4_Prototype
{
    public partial class Form1 : Form
    {
        private Scheme scheme1 = new ConcreteScheme1();
        private Scheme scheme1Clone = new ConcreteScheme1();
        private Scheme scheme2 = new ConcreteScheme2();
        private Scheme scheme2Clone = new ConcreteScheme2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            scheme1.Bdy.Add(new Body((int)numericUpDown1.Value, textBox1.Text));
            listBox1.Items.Add(textBox1.Text+"\t"+(int)numericUpDown1.Value);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            scheme1Clone = scheme1.Clone();
            listBox2.Items.Clear();
            foreach(Body b in scheme1Clone.Bdy)
            {
                listBox2.Items.Add(b.Name + "\t" + b.Length);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            scheme2.Bdy.Add(new Body((int)numericUpDown2.Value, textBox2.Text));
            listBox3.Items.Add(textBox2.Text + "\t" + (int)numericUpDown2.Value);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            scheme2Clone = scheme2.Clone();
            listBox4.Items.Clear();
            foreach (Body b in scheme2Clone.Bdy)
            {
                listBox4.Items.Add(b.Name + "\t" + b.Length);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (Body b in scheme1Clone.Bdy)
            {
                listBox2.Items.Add(b.Name + "\t" + b.Length);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            foreach (Body b in scheme2Clone.Bdy)
            {
                listBox4.Items.Add(b.Name + "\t" + b.Length);
            }
        }
    }
}
