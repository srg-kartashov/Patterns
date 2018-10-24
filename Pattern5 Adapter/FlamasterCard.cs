namespace Pattern5_Adapter
{
    class FlamasterCard
    {
        public void Send(ISingleBank s)
        {
            s.Send("123",10);
        }
    }
}
