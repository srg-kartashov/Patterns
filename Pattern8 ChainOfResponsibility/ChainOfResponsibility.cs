using System.Windows.Forms;

namespace Pattern8_ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler()
        {

        }
        public Handler(int mass,int size)
        {
            Mass = mass;
            Size = size;
        }
        public int Mass{ get; set; }
        public int Size{ get; set; }
        public Handler Successor { get; set; }
        public abstract void Display(ListBox l);
        public abstract void MassRequest(int mass, ListBox l);
        public abstract void SizeRequest(int size, ListBox l);
    }

    public class ConcreteMechBody : Handler
    {
        public override void Display(ListBox l)
        {
            l.Items.Add(Mass + "  " + Size);
        }
        public ConcreteMechBody()
        {

        }

        public ConcreteMechBody(int mass, int size)
            : base(mass,size)
        {

        }
        public override void MassRequest(int request,ListBox l)
        {
            if (Mass == request)
                l.Items.Add("Объект найден. Масса = " + Mass + " Размер = " + Size );
            else if (Successor != null)
                Successor.MassRequest(request, l);
            else
                l.Items.Add("Объект НЕ найден");
        }
        public override void SizeRequest(int request, ListBox l)
        {
            if (Size == request)
                l.Items.Add("Объект найден. Масса = " + Mass + " Размер = " + Size);
            else if (Successor != null)
                Successor.SizeRequest(request,l);
            else
                l.Items.Add("Объект НЕ найден");
        }

    }


}
