using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pattern3_Factory_Method
{
    public partial class Form1 : Form
    {
        private List<TextFile> textFilesList;
        private Creator[] creators;
        public Form1()
        {
            InitializeComponent();
            textFilesList = new List<TextFile>();
            creators = new Creator[2];
            creators[0] = new ConcreteCreatorTXT();
            creators[1] = new ConcreteCreatorRTF();
            comboBoxExtension.SelectedIndex = 0;
        }

        private void ButtonCreateFile_Click(object sender, EventArgs e)
        {
            int i = comboBoxExtension.SelectedIndex;
            textFilesList.Add(creators[i].FactoryMethod(textBoxFileName.Text,textBoxFileText.Text));

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start(System.IO.Directory.GetCurrentDirectory());
        }

        
    }
   
}
