using System.Windows.Forms;

namespace Pattern7_Facade
{
    // ReSharper disable once InconsistentNaming
    class CPU
    {
        public void Load(ListBox l)
        {
            l.Items.Add("Загрузка центрального процессора");
        }
    }
}
