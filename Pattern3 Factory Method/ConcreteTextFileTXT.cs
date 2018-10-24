using System.IO;


namespace Pattern3_Factory_Method
{
    class ConcreteTextFileTXT : TextFile
    {
        public override string FileName { get; set; }

        public override string Text { get; set; }

        public ConcreteTextFileTXT(string fileName, string text)
        {
            using (StreamWriter sw = new StreamWriter(fileName+".txt",false))
            {
                sw.WriteLine(text);
            }
        }


    }
}
