using System;
using System.Windows.Forms;

namespace Pattern5_Adapter
{
    public partial class Form1 : Form
    {
        BayBank bb = new BayBank();
        BetaBank be = new BetaBank();
        PrivetBank pb = new PrivetBank();
        FlamasterCard fc = new FlamasterCard();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fc.Send(bb);
            listBox1.Items.Add("Отправлено с BayBank");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            fc.Send(new BetaBankToSingleBank(be));
            listBox1.Items.Add("Отправлено с BetaBank");
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            fc.Send(new PrivetBankToSingleBank(pb));
            listBox1.Items.Add("Отправлено с PrivetBank");
        }
    }
}
