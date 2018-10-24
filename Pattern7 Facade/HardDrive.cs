using System.Windows.Forms;

namespace Pattern7_Facade
{
    class HardDrive
    {
        public void Load(ListBox l)
        {
            l.Items.Add("Загрузка жесткого диска");
        }
    }
}
