using System.Windows.Forms;


namespace Pattern3_Factory_Method
{
    class ConcreteTextFileRTF : TextFile
    {
        public override string FileName { get; set; }

        public override string Text { get; set; }

        public ConcreteTextFileRTF(string fileName, string text)
        {
            //try
            //{
            RichTextBox rtb = new RichTextBox {Text = text};
            rtb.Rtf = rtb.Rtf;
            rtb.SaveFile(fileName + ".rtf", RichTextBoxStreamType.RichText);

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
    }
}
