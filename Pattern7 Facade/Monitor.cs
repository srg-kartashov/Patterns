using System.Windows.Forms;

namespace Pattern7_Facade
{
    class Monitor
    {
        public bool Enabled;
        public void Switch(ListBox l)
        {
            if (!Enabled)
            {
                l.Items.Add("Включение монитора");
                Enabled = true;
            }
            else
            {
                l.Items.Add("Выключение монитора");
                l.Items.Clear();
                Enabled = false;
            }
        }

        public void Display(ListBox l, string txt)
        {
           
                l.Items.Add(txt);
 
        }
    }
}
