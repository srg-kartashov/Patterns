using System;
using System.Windows.Forms;

namespace Pattern1_AbstractFactory
{
    public partial class Form1 : Form
    {
        private AbstractFactory factory1;
        private AbstractFactory factory2;
        private Client c1;
        private Client c2;
        public Form1()
        {
            
            InitializeComponent();

        }

        private void ButtonClient1_Click(object sender, EventArgs e)
        {
            factory1 = new ConcreteFactory1();
            c1 = new Client(factory1, textBoxNameA1.Text, (float)numericUpDownMassA1.Value, (float)numericUpDownVeloA1.Value, (float)numericUpDownAccelerA1.Value, textBoxNameB1.Text, (float)numericUpDownMassB1.Value, (float)numericUpDownVeloB1.Value, (float)numericUpAccelerB1.Value);
            buttonMoveC1.Enabled = true;
            Log(c1.Info());
        }

        private void ButtonClient2_Click(object sender, EventArgs e)
        {
            factory2 = new ConcreteFactory2();
            c2 = new Client(factory2, textBoxNameA2.Text, (float)numericUpDownMassA2.Value, (float)numericUpDownVeloA2.Value, (float)numericUpDownAccelerA2.Value, textBoxNameB2.Text, (float)numericUpDownMassB2.Value, (float)numericUpDownVeloB2.Value, (float)numericUpDownAccelerB2.Value);
            buttonMoveC2.Enabled = true;
            Log(c2.Info());
        }

        public void Log(string s)
        {
            listBox1.Items.Add(s);
        }

        private void ButtonMoveC1_Click(object sender, EventArgs e)
        {
            c1.MoveProducts();
            Log("Client 1 move");
        }

        private void ButtonMoveC2_Click(object sender, EventArgs e)
        {
            c2.MoveProducts();
            Log("Client 2 move");
        }

    }


}
