namespace Pattern5_Adapter
{
    interface ISingleBank
    {
        void Send(string recipient, int money);
    }
    class BayBank : ISingleBank
    {
        public void Send(string recipient, int money)
        {

        }

    }
}
