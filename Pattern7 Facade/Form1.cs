using System;
using System.Windows.Forms;

namespace Pattern7_Facade
{
    public partial class Form1 : Form
    {
        private Computer computer;
        public Form1()
        {
            InitializeComponent();
            computer = new Computer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            computer.Switch(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            computer.SwitchMonitor(listBox1);
            listBox1.Visible = !listBox1.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            computer.Display(listBox1, "Вы вводите текст");
        }

        

    }
}
