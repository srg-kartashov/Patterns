using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pattern2_Builder
{
    public partial class Form1 : Form
    {
        private Golf2Builder golf2Builder;
        private LancerBuilder lancerBuilder;
        private TransporterT6Builder transporterT6Builder;
        private Buy buy;
        private List<Car> salon;
        private string[] carsList = { "Volkswagen Golf II", "Mitsubishi Lancer", "Volkswagen Transporter (T6)" };
        public Form1()
        {
            InitializeComponent();
            golf2Builder = new Golf2Builder();
            lancerBuilder = new LancerBuilder();
            transporterT6Builder = new TransporterT6Builder();
            buy = new Buy();
            salon = new List<Car>();

            comboBox1.Items.AddRange(carsList);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Volkswagen Golf II":
                    {
                        buy.ConstructCar(golf2Builder);
                        salon.Add(golf2Builder.GetNewCar());
                        listBox1.Items.Add(carsList[0]);
                        break;
                    }
                case "Mitsubishi Lancer":
                    {
                        buy.ConstructCar(lancerBuilder);
                        salon.Add(lancerBuilder.GetNewCar());
                        listBox1.Items.Add(carsList[1]);
                        break;
                    }
                case "Volkswagen Transporter (T6)":
                    {
                        buy.ConstructCar(transporterT6Builder);
                        salon.Add(transporterT6Builder.GetNewCar());
                        listBox1.Items.Add(carsList[2]);
                        break;
                    }
            }
        }
    }
}
