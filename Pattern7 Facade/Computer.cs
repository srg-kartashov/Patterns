using System.Windows.Forms;

namespace Pattern7_Facade
{
    class Computer
    {
        private bool enabled;
        private CPU cpu = new CPU();
        private HardDrive hardDrive = new HardDrive();
        private Memory memory = new Memory();
        private Monitor monitor = new Monitor();
        public void Switch(ListBox l)
        {
            if (enabled)
            {
                l.Items.Add("Выключаем компьютер");
                l.Items.Clear();
            }
            else
            {
                cpu.Load(l);
                memory.Load(l);
                hardDrive.Load(l);
                
                l.Items.Add("Включаем компьютер");
            }
            enabled = !enabled;

        }
        public void Display(ListBox l, string txt)
        {
            if (enabled)
            {
                monitor.Display(l, txt);
            }
            else
            {
                l.Items.Add("Компьютер выключен. Включите компьютер для начала работы");
            }
        }
        public void SwitchMonitor(ListBox l)
        {
            monitor.Switch(l);
        }

    }
}
